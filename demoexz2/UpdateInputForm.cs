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

namespace demoexz2
{
    public partial class UpdateInputForm : Form
    {
        string type, name, director, phone, raiting, email, id;

        private void labelTip_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool condition; // false - редактирование, true - добавление
        public UpdateInputForm()
        {
            InitializeComponent();
            SetTypes();
        }
        public void SetData(string type, string name, string director, string phone, string raiting, string id)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.director = director;
            this.phone = phone;
            this.raiting = raiting;
            condition = false;

            comboBox1.SelectedItem = type;
            labelNaimenovanie.Text = name;
            labelDirector.Text = director;
            labelNomer.Text = phone;
            labelRaiting.Text = raiting;

            FormProperty();
        }
        public void SetData() 
        {
            condition = true;
            FormProperty();
        }
        public void SetTypes()
        {
            using (SqlConnection connection = new SqlConnection(new MainForm()._connectionString)) 
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Select * from Типы_партнеров", connection)) 
                {
                    
                    using (var reader = command.ExecuteReader()) 
                    {
                        while (reader.Read()) 
                        {
                            comboBox1.Items.Add(reader["Наименование"].ToString());
                        }
                    }
                }
            }
        }
        public void FormProperty() 
        {
            if (condition)
            {
                this.Text = "Добавление сущности";
                button1.Text = "Добавить";
                button1.Click += InsertData;
            }
            else
            {
                this.Text = "Изменение сущности";
                button1.Text = "Изменить";
                button1.Click += UpdateData;
            }
        }
        public void UpdateData(object sender, EventArgs e) 
        {
            using(SqlConnection connection = new SqlConnection(new MainForm()._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand($"update Партнеры set Тип_партнера = {ConvertTypeInID()}, Наименование = '{labelNaimenovanie.Text}', Директор = '{labelDirector.Text}', Электронная_почта = '{textBox1.Text}', Телефон = '{labelNomer.Text}', Рейтинг = {labelRaiting.Text}, Юридический_адрес = '{textBox2.Text}' where Код = '{id}'", connection)) 
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        private void InsertData(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(new MainForm()._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand($"INSERT INTO Партнеры (Тип_партнера, Наименование, Директор, Электронная_почта, Телефон, Юридический_адрес, Рейтинг) values ({ConvertTypeInID()}, '{labelNaimenovanie.Text}', '{labelDirector.Text}', '{textBox1.Text}', '{labelNomer.Text}','{textBox2.Text}', {labelRaiting.Text} )", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        private string ConvertTypeInID() 
        {
            string value;
            using (SqlConnection connection = new SqlConnection(new MainForm()._connectionString))
            using (SqlCommand command = new SqlCommand($"select Код from Типы_партнеров where Наименование = '{comboBox1.Text}'", connection))
            {
                connection.Open();
                value = command.ExecuteScalar().ToString();
            }
            return value;
        }
    }
}
