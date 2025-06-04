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
            InitializeComponent("DelObject");
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeComponent(string v)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();

            var Name = namebox.Text;
            var Count = countbox.Text;
            var Storage = storagebox.Text;
            var Slot = slotbox.Text;
            var addQuery = $"delete from Object where Name = '{Name}' and ID_Storage = {Storage} and Slot = {Slot}";
            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись Удалена.", "Запись Удалена.", MessageBoxButtons.OK);

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
