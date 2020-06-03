using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelClient.controller
{
    public partial class UC_TodoLIst : UserControl
    {
        public UC_TodoLIst()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void lbl_date_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_date.Text = dt.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
