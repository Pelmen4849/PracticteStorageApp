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
    public partial class Register : Form
    {
        
        DataBase dataBase = new DataBase();
        
        public Register(string v)
        {
            InitializeComponent(v);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeComponent(string v)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();


            var Fam = this.Fambox.Text;
            var Name = namebox.Text;
            var OtcheNash = Surnamebox.Text;
            var Telephone_Number = this.Telephonebox.Text;
            var Login = this.Loginbox.Text;
            var Password = this.Passwordbox.Text;
            var addQuery = $"insert into Register(Fam, Name, OtcheNash, Telephone_Number, Login, Password  ) values ('{Fam}', '{Name}', '{OtcheNash}', '{Telephone_Number}', '{Login}', '{Password}')";

            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись Добавлена.", "Запись Добавлена.", MessageBoxButtons.OK);
            Login login = new Login();
            this.Hide();
            login.Show();
            dataBase.CloseConnection();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
