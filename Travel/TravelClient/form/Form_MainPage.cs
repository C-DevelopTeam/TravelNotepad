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
    public partial class Form_MainPage : Form
    {
        private Point mousePoint = new Point();

        public Form_MainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form_Register reg = new Form_Register())
            {
                this.Hide();
                reg.ShowDialog();
                this.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Form_TripNote tn = new Form_TripNote())
            {
                this.Hide();
                tn.ShowDialog();
                this.Show();
            }
        }

        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.mousePoint.X = e.X;
            this.mousePoint.Y = e.Y;
        }

        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Top = Control.MousePosition.Y - mousePoint.Y;
                this.Left = Control.MousePosition.X - mousePoint.X;
            }
        }
    }
}
