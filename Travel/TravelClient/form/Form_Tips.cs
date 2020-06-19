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
    public partial class Form_Tips : Form
    {
        private Point formPoint = new Point();

        public Form_Tips(string title,string info)
        {
            InitializeComponent();
            Lbl_info.Text = info;
            Lbl_title.Text = title;
            SetFont();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void SetFont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\font\造字工房映力黑规体.otf");//字体的路径及名字
                Font titleFont12 = new Font(font.Families[0], 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                Font titleFont10 = new Font(font.Families[0], 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                Lbl_title.Font = titleFont12;
                Lbl_info.Font = titleFont10;
                Btn_confirm.Font = titleFont10;

            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form_Tips_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        private void Form_Tips_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }
    }
}
