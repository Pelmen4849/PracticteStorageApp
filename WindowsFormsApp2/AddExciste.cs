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
        private const string V = "a";
        DataBase dataBase = new DataBase();
        public AddExciste(string v)
        {
            InitializeComponent(v);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeComponent(string v)
        {
            throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();


            var Name = namebox.Text;
            var Count = countbox.Text;
            var Storage = storagebox.Text;
            var Slot = slotbox.Text;
            var addQuery = $"update Object set name = '{Name}', Count = '{Count}', ID_Storage = '{Storage}', Slot = '{Slot}'";
            

            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись Обновленна.", "Запись Обновлена.", MessageBoxButtons.OK);

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
