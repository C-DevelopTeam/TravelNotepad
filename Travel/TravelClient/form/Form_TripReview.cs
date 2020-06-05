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
    public partial class Form_TripReview : Form
    {
        private Point mousePoint = new Point();

        public Form_TripReview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Form_MyTrip mt = new Form_MyTrip())
            {
                mt.ShowDialog();
            }
        }

        private void Form_TR_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void Form_TR_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
           
            }
        }

        private void Form_TR_MouseUp(object sender, MouseEventArgs e)
        {
    
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void pnl1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.mousePoint.X = e.X;
            this.mousePoint.Y = e.Y;
        }

        private void pnl1_MouseMove(object sender, MouseEventArgs e)
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
