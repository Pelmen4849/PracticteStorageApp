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

namespace WindowsFormsApp2
{
    public partial class AddNew : Form
    {
        DataBase dataBase = new DataBase();
        public AddNew()
        {
            InitializeComponent(GetV(V));
            StartPosition = FormStartPosition.CenterScreen;
        }

        private Label GetV(string v)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();

            
            var Name = textBox2.Text;
            var Count = textBox3.Text;
            int proverka = Convert.ToInt32(textBox3.Text);
            if(proverka > 0)
            {
                var Storage = textBox4.Text;
                var Slot = textBox5.Text;
                var addQuery = $"insert into Object(Name, Count, ID_Storage, Slot) values ('{Name}', '{Count}', '{Storage}', '{Slot}')";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись Добавлена.", "Запись Добавлена.", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("Количество должно быть больше 0!","Ошибка!" , MessageBoxButtons.OK);
            }

            

            dataBase.CloseConnection();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNew_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
