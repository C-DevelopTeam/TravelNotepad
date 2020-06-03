using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUtilHelpV2;

namespace TravelClient.form
{
    public partial class Sign : Form
    {
        

        public Sign()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        

        private void SignUp_Click(object sender, EventArgs e)
        {
            //判断注册条件
            Successful a = new Successful();
            this.Hide();
            a.Show();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Sign_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Sex_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
