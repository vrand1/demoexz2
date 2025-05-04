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
    public partial class CalcForm : Form
    {
        string material_name, material_brak;
        public CalcForm()
        {
            InitializeComponent();
            SetNames();
        }
        public void SetNames()
        {
            using (SqlConnection connection = new SqlConnection(new MainForm()._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Select * from Продукция", connection))
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
        private string ConvertNameInID()
        {
            string value;
            using (SqlConnection connection = new SqlConnection(new MainForm()._connectionString))
            using (SqlCommand command = new SqlCommand($"select Код from Продукция where Наименование = '{comboBox1.Text}'", connection))
            {
                connection.Open();
                value = command.ExecuteScalar().ToString();
            }
            return value;
        }
        private string ProductType()
        {
            string value;
            using (SqlConnection connection = new SqlConnection(new MainForm()._connectionString))
            using (SqlCommand command = new SqlCommand($"select Тип_продукции from Продукция where Наименование = '{comboBox1.Text}'", connection))
            {
                connection.Open();
                value = command.ExecuteScalar().ToString();
            }
            return value;
        }
        private string koef() 
        {
            string value;
            using (SqlConnection connection = new SqlConnection(new MainForm()._connectionString))
            using (SqlCommand command = new SqlCommand($"select Коэффициент from Типы_продукции where Код = {ProductType()}", connection))
            {
                connection.Open();
                value = command.ExecuteScalar().ToString();
            }
            return value;
        }
        private string material_type()
        {
            string value;
            using (SqlConnection connection = new SqlConnection(new MainForm()._connectionString))
            using (SqlCommand command = new SqlCommand($"select Код_типа_материала from Материалы_в_продукции where Код_продукции = {ProductType()}", connection))
            {
                connection.Open();
                value = command.ExecuteScalar().ToString();
            }
            return value;
        }
        private void NameAndBrakMaterial()
        {
            using (SqlConnection connection = new SqlConnection(new MainForm()._connectionString))
            using (SqlCommand command = new SqlCommand($"select Наименование, Процент_брака from Типы_материалов where Код = {material_type()}", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    material_name = reader["Наименование"].ToString();
                    material_brak = reader["Процент_брака"].ToString();
                }
            }
        }
        private void Calc() 
        {
            ConvertNameInID(); // хз просто по условиям надо
            NameAndBrakMaterial();
            int par1 = Convert.ToInt32(textBoxPar1.Text);
            int par2 = Convert.ToInt32(textBoxPar2.Text);
            int count = Convert.ToInt32(textBoxCount.Text);
            double koefi = Convert.ToDouble(koef());
            double material_brak_f = Convert.ToDouble(material_brak);
            label2.Text =  $"Для продукта {comboBox1.Text} в количестве {count} необходимо "+(Math.Ceiling(count*((par1 * par2 * koefi) * (1 + (material_brak_f / 100))))).ToString() + $" материала {material_name}";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calc();
        }
    }
}
