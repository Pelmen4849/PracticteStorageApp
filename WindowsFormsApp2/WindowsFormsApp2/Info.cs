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
    enum RoWState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    
    public partial class Info : Form
    {
        DataBase dataBase = new DataBase();

        public Info()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("Name", "Название предмета");
            dataGridView1.Columns.Add("Count", "Количество");
            dataGridView1.Columns.Add("ID_Storage", "Склад");
            dataGridView1.Columns.Add("Slot", "Ячейки");
            dataGridView1.Columns.Add("Isnew", String.Empty);
            
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), RoWState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw, string sortOption = "")
        {
            dgw.Rows.Clear();

            string queryString = "select * from Object";

            // Добавляем сортировку в зависимости от выбранного варианта
            switch (sortOption)
            {
                case "Имя (А-Я)":
                    queryString += " ORDER BY Name ASC";
                    break;
                case "Имя (Я-А)":
                    queryString += " ORDER BY Name DESC";
                    break;
                case "Кол-во (↑)":
                    queryString += " ORDER BY Count ASC";
                    break;
                case "Кол-во (↓)":
                    queryString += " ORDER BY Count DESC";
                    break;
                case "Склад (А-Я)":
                    queryString += " ORDER BY ID_Storage ASC";
                    break;
                case "Склад (Я-А)":
                    queryString += " ORDER BY ID_Storage DESC";
                    break;
                default:
                    // Без сортировки
                    break;
            }

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
   
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = EnterItem.Text;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Name = EneterID.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
        private void searchName(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Object where Name  like '%" + EnterItem.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        private void searchStorage(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Object where ID_Storage  like '%" + EneterID.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchName(dataGridView1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            searchStorage(dataGridView1);
        }
    }
}
