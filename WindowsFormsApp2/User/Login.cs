using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        DataBase dataBase = new DataBase();
        private int count = 0;
        private System.Threading.Timer blockTimer;
        private string captchaText;
        private string V;

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            captchbox.Hide();
            captchpic.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register(V);
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var LogInUser = logbox.Text;
            var PassUser = passwordbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string QueryString = $"select Login, Password from Register where Login = '{LogInUser}' and Password = '{PassUser}'";
            SqlCommand command = new SqlCommand(QueryString, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.ShowDialog();
            }
            else
            {
                // Показываем капчу только если это первая неудачная попытка
                if (count == 0)
                {
                    GenerateNewCaptcha();
                    captchpic.Show();
                    captchbox.Show();
                }

                if (count > 0 && !captchbox.Text.Equals(captchaText, StringComparison.OrdinalIgnoreCase))
                {
                    GenerateNewCaptcha();
                    captchbox.Clear();
                    count++;
                }
                else if (count > 0)
                {
                    // Сбрасываем счетчик при правильной капче
                    count = 0;
                    captchbox.Hide();
                    captchpic.Hide();
                    captchbox.Clear();
                    return;
                }
                else
                {
                    count++;
                }

                if (count >= 2)
                {
                    BlockUserInterface();
                }
            }
        }

        private void BlockUserInterface()
        {
            enter.Enabled = false;
            registration.Enabled = false;
            captchbox.Enabled = false;

            // Блокируем на 10 секунд
            blockTimer = new System.Threading.Timer(UnblockUserInterface, null, 10000, Timeout.Infinite);
            MessageBox.Show("Попробуйте через 10 секунд.", "Блокировка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void UnblockUserInterface(object state)
        {
            // Этот метод вызывается в потоке таймера, поэтому используем Invoke
            this.Invoke((MethodInvoker)delegate
            {
                enter.Enabled = true;
                registration.Enabled = true;
                captchbox.Enabled = true;
                count = 1;
                captchbox.Hide();
                captchpic.Hide();
                captchbox.Clear();

                // Освобождаем таймер
                blockTimer?.Dispose();
            });
        }

        private void GenerateNewCaptcha()
        {
            captchaText = GenerateRandomText(5);
            captchpic.Image = GenerateCaptchaImage(captchaText, captchpic.Width, captchpic.Height);
        }

        private string GenerateRandomText(int length)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghjkmnpqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private Bitmap GenerateCaptchaImage(string text, int width, int height)
        {
            var bitmap = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                // Очищаем фон
                graphics.Clear(Color.White);

                var random = new Random();

                // Добавляем шумовые линии (меньше и короче)
                for (int i = 0; i < 8; i++)
                {
                    int x1 = random.Next(0, width / 2);
                    int y1 = random.Next(0, height);
                    int x2 = random.Next(width / 2, width);
                    int y2 = random.Next(0, height);

                    graphics.DrawLine(
                        new Pen(Color.FromArgb(random.Next(180, 220), random.Next(180, 220), random.Next(180, 220))),
                        x1, y1, x2, y2
                    );
                }

                // Используем меньший размер шрифта и учитываем границы
                using (var font = new Font("Arial", 18, FontStyle.Bold))
                {
                    // Начальные координаты с отступом от краев
                    float x = 15;
                    float y = height / 3f;

                    // Максимальное смещение символов
                    float maxYOffset = height / 4f;
                    float charSpacing = 18;

                    for (int i = 0; i < text.Length; i++)
                    {
                        // Случайное смещение
                        float yOffset = random.Next((int)-maxYOffset, (int)maxYOffset);
                        float xOffset = random.Next(-5, 5);

                        // Случайный поворот (меньший угол)
                        float angle = random.Next(-20, 20);

                        // Сохраняем текущие настройки
                        var oldTransform = graphics.Transform;

                        // Применяем трансформации
                        graphics.TranslateTransform(x + xOffset, y + yOffset);
                        graphics.RotateTransform(angle);

                        // Рисуем символ
                        graphics.DrawString(
                            text[i].ToString(),
                            font,
                            Brushes.Black,
                            new PointF(0, 0));

                        // Восстанавливаем настройки
                        graphics.Transform = oldTransform;

                        // Сдвигаем позицию для следующего символа
                        x += charSpacing + random.Next(-3, 3);

                        // Проверяем, не вышли ли за границы
                        if (x > width - 30) break;
                    }
                }

                // Добавляем перечеркивание (если нужно)
                if (random.Next(2) == 0)
                {
                    int lineY = random.Next(height / 3, height * 2 / 3);
                    graphics.DrawLine(
                        new Pen(Color.Red, 1.5f),
                        new Point(10, lineY),
                        new Point(width - 10, lineY + random.Next(-5, 5))
                    );
                }
            }
            return bitmap;
        }
    }
}