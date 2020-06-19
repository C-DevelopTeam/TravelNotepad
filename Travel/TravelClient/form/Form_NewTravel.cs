using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TravelClient.controller;
using TravelClient.Models;
using TravelClient.utils;

namespace TravelClient.form
{
    public partial class Form_NewTravel : Form
    {
        public int Uid;
        public string travelTitle;
        public string cityOfTravel;
        public Delegate_init init;

        private Point formPoint = new Point();

        public Form_NewTravel(int uid, Delegate_init init)
        {
            Uid = uid;
            this.init = init;
            InitializeComponent();
            SetFont();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
           this.Dispose();
        }

        private void Btn_ConfirmToCreate_Click(object sender, EventArgs e)
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
                Font titleFont18 = new Font(font.Families[0], 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

                //设置窗体控件字体，哪些控件要更改都写到下面

                Lbl_title.Font = titleFont18;
                Lbl_tip1.Font = titleFont12;
                Lbl_tip2.Font = titleFont12;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form_NewTravel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        private async void AddTravel(string title, int uid)
        {
            Travel travel = new Travel();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Travel));
            Client client = new Client();
            string data = "";

            try
            {
                string url = "https://localhost:5001/api/Travel";
                travel.Description = title;
                travel.Uid = uid;

                using (StringWriter sw = new StringWriter())
                {
                    xmlSerializer.Serialize(sw, travel);
                    data = sw.ToString();
                }
                HttpResponseMessage result = await client.Post(url, data);
                if (result.IsSuccessStatusCode)
                {
                    /*User newuser = new User();
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
                    }*/
                    using (Form_Tips tip = new Form_Tips("警告", "成功"))
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

        private void Form_NewTravel_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }
    }
}
