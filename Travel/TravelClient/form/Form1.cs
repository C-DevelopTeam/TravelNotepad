using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelClient.form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Form_CreateTrip ct = new Form_CreateTrip())
            {
                ct.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Form_MyTrip mt = new Form_MyTrip())
            {
                mt.ShowDialog();
            }
        }
    }
}
