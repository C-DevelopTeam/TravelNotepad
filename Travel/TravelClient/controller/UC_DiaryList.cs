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
using System.Xml.Serialization;
using TravelClient.Models;
using TravelClient.utils;
using System.Net.Http;

namespace TravelClient.controller
{
    public partial class UC_DiaryList : UserControl
    {
        private string Uid;
        public UC_DiaryList(string uid)
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
                font.AddFontFile(AppPath + @"\font\SF-Pro-Text-Medium.otf");

                Font titleFont25 = new Font(font.Families[1], 25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font SFProFont12 = new Font(font.Families[0], 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                label1.Font = titleFont25;
                btnAddDiary.Font = SFProFont12;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void InitInfo()
        {
            string id = this.Uid;
            string url = "https://localhost:5001/api/blogger/get/userall?uid=" + id;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Diary>));
            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    List<Diary> diaries = (List<Diary>)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                    panelDiaryList.Controls.Clear();

                    foreach (Diary diary in diaries)
                    {
                        UC_DiaryCell cell = new UC_DiaryCell();
                        cell.lblTitle.Text = diary.Title;
                        cell.lblTime.Text = diary.Time.ToString();
                        //添加到panel中
                        panelDiaryList.Controls.Add(cell);
                    }
                    //添加底部标志
                    Label lblBottom = new Label();
                    lblBottom.Text = "到底了哦~";
                    lblBottom.Font = btnAddDiary.Font;
                    lblBottom.Anchor = AnchorStyles.None;
                    panelDiaryList.Controls.Add(lblBottom);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnAddDiary_Click(object sender, EventArgs e)
        {
            //添加日志，跳转至编辑日志界面
        }
    }
}
