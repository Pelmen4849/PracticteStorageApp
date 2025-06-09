using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class DelObject : Form
    {
        DataBase dataBase = new DataBase();
        public DelObject()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Name = namebox.Text;
            var Count = countbox.Text;
            var Storage = storagebox.Text;
            var Slot = slotbox.Text;

            if (!int.TryParse(Count, out int countToRemove) || countToRemove <= 0)
            {
                MessageBox.Show("Количество должно быть целым числом больше 0!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }

            dataBase.OpenConnection();

            // Сначала проверим текущее количество
            var checkQuery = $"SELECT Count FROM Object WHERE Name = '{Name}' AND ID_Storage = '{Storage}' AND Slot = '{Slot}'";
            var checkCommand = new SqlCommand(checkQuery, dataBase.GetConnection());
            var currentCount = Convert.ToInt32(checkCommand.ExecuteScalar());

            if (currentCount < countToRemove)
            {
                MessageBox.Show($"Недостаточно товара на складе! Текущее количество: {currentCount}", "Ошибка!", MessageBoxButtons.OK);
                dataBase.CloseConnection();
                return;
            }

            if (MessageBox.Show($"Списать {countToRemove} единиц товара {Name}?", "Подтверждение",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                dataBase.CloseConnection();
                return;
            }

            // Обновляем количество (уменьшаем на указанное значение)
            var updateQuery = $"UPDATE Object SET Count = Count - {countToRemove} WHERE Name = '{Name}' AND ID_Storage = '{Storage}' AND Slot = '{Slot}'";
            var command = new SqlCommand(updateQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();

            // Проверяем, не стало ли количество 0 или меньше, и удаляем запись если нужно
            if (currentCount - countToRemove <= 0)
            {
                var deleteQuery = $"DELETE FROM Object WHERE Name = '{Name}' AND ID_Storage = '{Storage}' AND Slot = '{Slot}'";
                var deleteCommand = new SqlCommand(deleteQuery, dataBase.GetConnection());
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Товар полностью списан и удален из базы.", "Успешно", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Товар списан. Осталось: {currentCount - countToRemove}", "Успешно", MessageBoxButtons.OK);
            }

            dataBase.CloseConnection();
        }

        private void Delete_Object_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();
        }
    }
}
