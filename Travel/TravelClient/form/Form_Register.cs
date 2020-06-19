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
using System.Xml.Serialization;
using TravelClient.Models;
using TravelClient.utils;

namespace TravelClient.form
{
    public partial class Form_Register : Form
    {
        private Point formPoint = new Point();
        private string baseUrl = "https://localhost:5001/api/user";

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

                Font jokermanFont18 = new Font(font.Families[0], 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font titleFont14 = new Font(font.Families[1], 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                Font titleFont11 = new Font(font.Families[1], 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                label1.Font = titleFont14;
                label2.Font = titleFont11;
                label3.Font = titleFont11;
                label4.Font = titleFont11;
                label5.Font = titleFont11;
                label6.Font = jokermanFont18;
                Btn_Register.Font = titleFont11;
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

        private async void button6_Click(object sender, EventArgs e)
        {
            if (Txtbox_name.Text.Length == 0 || Txtbox_name.Text == "单行输入")
                using (Form_Tips tip = new Form_Tips("提示", "请输入用户名!"))
                {
                    tip.ShowDialog();
                }
            else
               if (TxtBox_psw.Text.Length == 0 || TxtBox_psw.Text == "单行输入")
                using (Form_Tips tip = new Form_Tips("提示", "请输入密码!"))
                {
                    tip.ShowDialog();
                }
            else
            {
                User user = new User();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));
                Client client = new Client();
                string data = "";

                try
                {
                    string url = baseUrl + "/register";
                    user.Uname = Txtbox_name.Text;
                    user.Password = MD5Encrypt(TxtBox_psw.Text);
                    user.Sex = Cbbox_gender.Text;
                    user.Introduction = richTextBox_introducation.Text;
                    
                    using (StringWriter sw = new StringWriter())
                    {
                        xmlSerializer.Serialize(sw, user);
                        data = sw.ToString();
                    }
                    HttpResponseMessage result = await client.Post(url,data);
                    if (result.IsSuccessStatusCode)
                    {
                        User newuser = new User();
                        newuser = (User)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                        user.Uid = int.Parse(newuser.Uid.ToString("00000"));
                        using (Form_Tips tip = new Form_Tips("提示", "注册成功!您的ID是" + newuser.Uid.ToString("00000")))
                        {
                            tip.ShowDialog();
                        }
                        using (Form_TripNote tn = new Form_TripNote())
                        {
                            this.Hide();
                            tn.ShowDialog();
                            this.Dispose();
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
