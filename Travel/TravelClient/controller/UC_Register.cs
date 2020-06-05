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
    public partial class UC_Register : UserControl
    {
        public UC_Register()
        {
            InitializeComponent();
            textBox5.BorderStyle = BorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.ToString() == textBox4.Text.ToString())
            {
                this.Dispose();
            }
            else
            {
                textBox5.Text = "密码输入不一致！";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.BorderStyle = BorderStyle.None;
        }
    }
}
