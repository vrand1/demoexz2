using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoexz2
{
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
        }
        public void SetData(string date, string prod, string count) 
        {
            labelCount.Text = count;
            labelDate.Text = date;
            labelName.Text = prod;
        }
    }
}
