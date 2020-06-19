using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelClient.utils;

namespace TravelClient.form
{
    public partial class Form_MainPage : Form
    {
        private Point formPoint = new Point();

        private Point mousePoint = new Point();

        private string baseUrl = "https://localhost:5001/api/user";

        //private long Uid { get; set; }

        //private string password;

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

                Font jokermanFont22 = new Font(font.Families[0], 22F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font titleFont12 = new Font(font.Families[1], 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                Font titleFont10 = new Font(font.Families[1], 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                label1.Font = titleFont12;
                label2.Font = titleFont12;
                label3.Font = jokermanFont22;
                button6.Font = titleFont12;
                button1.Font = titleFont10;
            }
            catch
            {
                using (Form_Tips tip = new Form_Tips("警告", "字体不存在或加载失败\n程序将以默认字体显示"))
                {
                    tip.ShowDialog();
                }
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

        private async void button6_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string passwordMD5 = MD5Encrypt(password);

            if (username.Length == 0 || username == "单行输入")
            {
                DialogResult result;
                using (Form_Tips tip = new Form_Tips("提示", "用户ID为空，是否注册新账号"))
                {
                    tip.ShowDialog();
                    result = tip.DialogResult;
                }
                if (result == DialogResult.Yes)
                {
                    using (Form_Register reg = new Form_Register())
                    {
                        this.Hide();
                        reg.ShowDialog();
                        this.Show();
                    }
                }
            }
            else
            {
                if (password.Length == 0 || password == "单行输入")
                    using (Form_Tips tip = new Form_Tips("提示", "请输入密码！"))
                    {
                        tip.ShowDialog();
                    }
                else
                {
                    try
                    {
                        string url = baseUrl + "/login?Uid=" + username + "&password=" + passwordMD5;
                        Client client = new Client();
                        HttpResponseMessage result = await client.Put(url,"");
                        if (result.IsSuccessStatusCode)
                        {
                            using (Form_TripNote tn = new Form_TripNote())
                            {
                                tn.changePanel = tn.AddControlsToPanel;
                                this.Hide();
                                tn.ShowDialog();
                                textBox1.Text = "";
                                textBox2.Text = "";
                                this.Show();
                            }
                        }
                        else
                        {
                            using (Form_Tips tip = new Form_Tips("警告", "用户名或密码输入错误"))
                            {
                                tip.ShowDialog();
                            }
                        }
                    }
                    catch (Exception e1)
                    {
                        using (Form_Tips tip = new Form_Tips("警告", e1.Message))
                        {
                            tip.ShowDialog();
                        }
                    }
                }
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

        private void Form_MainPage_Load(object sender, EventArgs e)
        {

        }

        private void Form_MainPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        private void Form_MainPage_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }

        public static string MD5Encrypt(string strText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] targetData = md5.ComputeHash(Encoding.UTF8.GetBytes(strText));

            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");
            }

            return byte2String.ToUpper();
        }
    }
}
