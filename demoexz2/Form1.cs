using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        
        public string _connectionString = "Server=DESKTOP-S6R4FFT;Database=demo2;uid=demo1;pwd=123;"; // свои данные подставьте
        public Form1()
        {
            InitializeComponent();
            LoadPartners();
        }

        
        private string discount(string PartnerID) 
        {
           try
            {
                int sum;
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand($"select sum(Количество) from Продажи where Партнер = {PartnerID}", connection))
                {
                    connection.Open();
                    sum = (Convert.ToInt32(command.ExecuteScalar()));
                }
                
                if (sum > 10000)
                {
                    if (sum > 50000)
                    {
                        if (sum > 300000)
                        {
                            return "15%";
                        }
                        return "10%";
                    }
                    return "5%";
                }
                return "0%";
            }
            catch { return "0%"; }

            
        }
        private void LoadPartners()
        {
            // Сильно ли надо пояснять за запрос?
            // p - таблица Партнеры, тама справа написанно
            // tp - Типы партнёров, чтобы там не цифорки писались
            // сортировка по рейтингу, самые лучшие среди первых йоу
            string query = @"
            SELECT
                p.Код,
                tp.Наименование AS Тип,
                p.Наименование AS Имя,
                p.Директор,
                p.Телефон,
                p.Рейтинг
            FROM Партнеры p
            JOIN Типы_партнеров tp ON p.Тип_партнера = tp.Код
            ORDER BY p.Рейтинг DESC;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var card = new Partner(this);
                    card.SetData(
                        reader["Тип"].ToString(),
                        reader["Имя"].ToString(),
                        discount(reader["Код"].ToString()), 
                        reader["Директор"].ToString(),
                        reader["Телефон"].ToString(),
                        reader["Рейтинг"].ToString(),
                        reader["Код"].ToString()
                    );
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma = new Form3();
            forma.FormClosed += FormUpdate;
            forma.SetData();
            forma.ShowDialog();
        }
        public void FormUpdate(object sender, EventArgs e) 
        { 
            flowLayoutPanel1.Controls.Clear();
            LoadPartners();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show();
        }
    }
}
