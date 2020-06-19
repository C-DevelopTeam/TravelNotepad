using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Xml;
using TravelClient.utils;
using System.Xml.Serialization;
using TravelClient.Models;
using System.Net.Http;
using System.IO;

namespace TravelClient.controller
{
    public partial class UC_Personalinfo : UserControl
    {
        private readonly string baseUrl = "https://localhost:5001/api/user";
        private readonly string Uid;
        public UC_Personalinfo(string uid)
        {
            InitializeComponent();
            this.Uid = uid;
            SetFont();
            InitInfo();
        }

        private void SetFont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\font\造字工房映力黑规体.otf");

                Font titleFont = new Font(font.Families[0], 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font titleFont10 = new Font(font.Families[0], 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                //设置窗体控件字体，哪些控件要更改都写到下面
                label1.Font = titleFont;
                label2.Font = titleFont;
                label3.Font = titleFont;
                label4.Font = titleFont;
                lblUserId.Font = titleFont;
                btnCommit.Font = titleFont10;
                tbDescription.Font = titleFont;
                tbUserName.Font = titleFont;
                cbGender.Font = titleFont;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void InitInfo()
        {
            //初始化相关信息
            string url = baseUrl + "/get?uid=" + this.Uid; 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));
            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    User user = (User)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                    lblUserId.Text = user.Uid.ToString("00000");
                    tbUserName.Text = user.Uname;
                    cbGender.Text = user.Sex;
                    tbDescription.Text = user.Introduction;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void BtnCommit_Click(object sender, EventArgs e)
        {
            //进行代码提交
            string id = lblUserId.Text;
            string url = baseUrl + "/update?uid=" + id;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));
            Client client = new Client();
            try
            {
                string data = "";
                HttpResponseMessage result = await client.Get(baseUrl + "/get?uid=" + id);
                if (result.IsSuccessStatusCode)
                {
                    User user = (User)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                    user.Uname = tbUserName.Text;
                    user.Sex = cbGender.Text;
                    user.Introduction = tbDescription.Text;

                    using(StringWriter sw = new StringWriter())
                    {
                        xmlSerializer.Serialize(sw, user);
                        data = sw.ToString();
                    }

                    result = await client.Put(url, data);
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
