using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelClient.Models;
using WinFormUtilHelpV2;



namespace TravelClient.form
{
    public partial class Login : Form
    {
        
            public Login()
            {
                InitializeComponent();
            }

            private void Login_Load(object sender, EventArgs e)
            {
                UserName.SetWatermark("请输入用户名称....");
                Password.SetWatermark("请输入用户密码....");
            }

            private void button1_Click(object sender, EventArgs e)
            {
            UserName.ClearWatermark();
            Password.ClearWatermark();
        }
        
        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        
        
        private void button2_Click(object sender, EventArgs e)
        {
            Sign a = new Sign();
            this.Hide();
            a.Show();
        }
    }
}
