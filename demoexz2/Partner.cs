using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoexz2
{
    public partial class Partner : UserControl
    {
        private Form1 mainform;
        string type, name, discount, director, phone, raiting,id;
        public Partner(Form1 form)
        {
            InitializeComponent();
            panel1.SendToBack();
            mainform = form;
        }
        public void SetData(string type, string name, string discount, string director, string phone, string raiting, string id)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.discount = discount;
            this.director = director;
            this.phone = phone;
            this.raiting = raiting;


            labelTip.Text = type;
            labelNaimenovanie.Text = name;
            labelSkidka.Text = discount;
            labelDirector.Text = director;
            labelNomer.Text = phone;
            labelRaiting.Text = raiting;
        }
        public void InputData() { }
        public void UpdateData() 
        {
            var form = new Form3();
            form.FormClosed += mainform.FormUpdate;
            form.SetData(type, name, director, phone, raiting, id);
            form.ShowDialog();

        }
        private void FormUpdate(object sender, EventArgs e)
        {
            
        }

        private void labelTip_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void labelNaimenovanie_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void labelSkidka_Click(object sender, EventArgs e)
        {

        }

        private void labelDirector_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void labelNomer_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void labelRaiting_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
