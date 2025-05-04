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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demoexz2
{
    public partial class HistoryForm : Form
    {
        string ID_partner;
        public HistoryForm(string ID_partner)
        {
            InitializeComponent();
            this.ID_partner = ID_partner;
            LoadPartnerHistory();
        }
        private void LoadPartnerHistory()
        {
            // Сильно ли надо пояснять за запрос?
            // p - таблица Партнеры, тама справа написанно
            // tp - Типы партнёров, чтобы там не цифорки писались
            // сортировка по рейтингу, самые лучшие среди первых йоу
            string query =  $@"
            SELECT
                Дата,
                Продукция,
                Количество
            FROM Продажи
            Where Партнер={ID_partner}";

            using (SqlConnection connection = new SqlConnection(new MainForm()._connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var card = new HistoryDesign();
                    card.SetData(
                        reader["Дата"].ToString(),
                        ConvertIdInName(reader["Продукция"].ToString()),
                        reader["Количество"].ToString()
                    );
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }
        private string ConvertIdInName(string ID_prod)
        {
            string value;
            using (SqlConnection connection = new SqlConnection(new MainForm()._connectionString))
            using (SqlCommand command = new SqlCommand($"select Наименование from Продукция where Код = {ID_prod}", connection))
            {
                connection.Open();
                value = command.ExecuteScalar().ToString();
            }
            return value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
