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
    public partial class UC_CreateTrip : UserControl
    {
        public UC_CreateTrip()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            rtb_detail.Text = label1.Text.ToString() + " " + listBox1.Text.ToString() + "--------" + tb_time1.Text.ToString() + "-" + tb_time2.Text.ToString() + " " + tb_place.Text.ToString(); 
        }
    }
}
