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
using TravelClient.form;
using System.IO;

namespace TravelClient.controller
{
    public delegate void Refresh();
    public partial class UC_DiaryList : UserControl
    {
        private readonly string Uid;
        private readonly ChangePanel ChangePanel;
        public UC_DiaryList(string uid, ChangePanel changePanel)
        {
            InitializeComponent();
            this.Uid = uid;
            this.ChangePanel = changePanel;
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

                Font titleFont18 = new Font(font.Families[1], 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                label1.Font = titleFont18;
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
                        UC_DiaryCell cell = new UC_DiaryCell(diary.DiaryId.ToString(), this.ChangePanel, this.InitInfo);
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
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnAddDiary_Click(object sender, EventArgs e)
        {
            //添加日志
            string url = "https://localhost:5001/api/diary";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Diary));
            Client client = new Client();
            try
            {
                string data = "";
                Diary diary = new Diary();
                diary.DiaryId = 0;//后端会重新赋值，此处值不重要
                diary.Time = DateTime.Now;
                diary.Share = 0;//默认不分享
                diary.Uid = Convert.ToInt32(this.Uid);

                using (StringWriter sw = new StringWriter())
                {
                    xmlSerializer.Serialize(sw, diary);
                    data = sw.ToString();
                }
                HttpResponseMessage result = await client.Post(url, data);
                if(result.IsSuccessStatusCode)
                {
                    diary = (Diary)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                    //跳转至编辑日志界面
                    using (UC_DiaryDetail uc_DiaryDetail = new UC_DiaryDetail(diary.DiaryId.ToString(),ChangePanel))
                    {
                        this.ChangePanel(uc_DiaryDetail);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
