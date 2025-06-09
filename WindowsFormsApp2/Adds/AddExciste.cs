using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class AddExciste : Form
    {
     
        DataBase dataBase = new DataBase();
        public AddExciste()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var Name = namebox.Text;
            var Count = countbox.Text;
            var Storage = storagebox.Text;
            var Slot = slotbox.Text;

            if (!int.TryParse(Count, out int countToAdd) || countToAdd <= 0)
            {
                MessageBox.Show("Количество должно быть целым числом больше 0!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }

            dataBase.OpenConnection();

            // Сначала проверим текущее количество
            var checkQuery = $"SELECT Count FROM Object WHERE Name = '{Name}' AND ID_Storage = '{Storage}' AND Slot = '{Slot}'";
            var checkCommand = new SqlCommand(checkQuery, dataBase.GetConnection());
            var currentCount = Convert.ToInt32(checkCommand.ExecuteScalar());
            if (MessageBox.Show($"Добавить {countToAdd} единиц товара {Name}?", "Подтверждение",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                dataBase.CloseConnection();
                return;
            }

            // Обновляем количество (уменьшаем на указанное значение)
            var updateQuery = $"UPDATE Object SET Count = Count + {countToAdd} WHERE Name = '{Name}' AND ID_Storage = '{Storage}' AND Slot = '{Slot}'";
            var command = new SqlCommand(updateQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show($"Товар добавлен. Итого: {currentCount + countToAdd}", "Успешно", MessageBoxButtons.OK);

            dataBase.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMain addmain = new AddMain();
            this.Hide();
            addmain.Show();
        }
    }
}
