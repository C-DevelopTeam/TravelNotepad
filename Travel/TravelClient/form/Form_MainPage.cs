using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
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

                Font jokermanFont35 = new Font(font.Families[0], 35F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font titleFont15 = new Font(font.Families[1], 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                Font titleFont10 = new Font(font.Families[1], 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                label1.Font = titleFont15;
                label2.Font = titleFont15;
                label3.Font = jokermanFont35;
                button6.Font = titleFont15;
                button1.Font = titleFont10;
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
