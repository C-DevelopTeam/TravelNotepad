using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelClient.form
{
    public partial class Form_Register : Form
    {
        private Point formPoint = new Point();

        public Form_Register()
        {
            InitializeComponent();
            SetFont();
        }

        public void SetFont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\font\JOKERMAN.TTF");//字体的路径及名字
                font.AddFontFile(AppPath + @"\font\造字工房映力黑规体.otf");

                Font jokermanFont25 = new Font(font.Families[0], 25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font titleFont15 = new Font(font.Families[1], 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                Font titleFont10 = new Font(font.Families[1], 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                label1.Font = titleFont15;
                label2.Font = titleFont10;
                label3.Font = titleFont10;
                label4.Font = titleFont10;
                label5.Font = titleFont10;
                label6.Font = jokermanFont25;
                Btn_Register.Font = titleFont10;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text == "单行输入")
                MessageBox.Show("请输入用户名!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
               if (textBox2.Text.Length == 0 || textBox2.Text == "单行输入")
                MessageBox.Show("请输入密码!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("注册成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                using (Form_TripNote tn = new Form_TripNote())
                {
                    tn.ShowDialog();
                    this.Dispose();
                }
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }
    }
}
