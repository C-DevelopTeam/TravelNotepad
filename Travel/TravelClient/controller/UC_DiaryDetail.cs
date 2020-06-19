using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelClient.form;
using System.Xml.Serialization;
using System.Drawing.Text;
using TravelClient.Models;
using TravelClient.utils;
using System.Net.Http;
using System.IO;

namespace TravelClient.controller
{
    public partial class UC_DiaryDetail : UserControl
    {
        private readonly string DiaryId;
        private readonly ChangePanel ChangePanel;
        private readonly string baseUrl = "https://localhost:5001/api/diary";
        public UC_DiaryDetail(string diaryId)
        {
            InitializeComponent();
            this.DiaryId = diaryId;
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

                Font titleFont = new Font(font.Families[0], 25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font btnFont = new Font(font.Families[0], 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font textFont = new Font(font.Families[1], 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                //设置窗体控件字体，哪些控件要更改都写到下面
                tbTitle.Font = titleFont;
                btnEdit.Font = btnFont;
                btnSave.Font = btnFont;
                btnShare.Font = btnFont;
                rtbDescription.Font = textFont;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //回退
        }

        private async  void BtnSave_Click(object sender, EventArgs e)
        {
            //保存修改
            tbTitle.Enabled = false;
            btnSave.Enabled = false;
            btnAddPic.Enabled = false;
            //将修改传到远端
            Diary diary = await GetDiary();
            diary.Title = tbTitle.Text;
            diary.Description = rtbDescription.Text;
            PutDiary(diary);
            //将编辑激活
            btnEdit.Text = "编辑";
            btnEdit.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //启用编辑
            btnEdit.Enabled = false;
            btnEdit.Text = "编辑中";
            tbTitle.Enabled = true;
            btnSave.Enabled = true;
            btnAddPic.Enabled = true;
        }

        private async void BtnShare_Click(object sender, EventArgs e)
        {
            //进行分享
            if(btnShare.Text.Equals("已分享"))
            {
                DialogResult dr = MessageBox.Show("确定取消分享？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(dr == DialogResult.Yes)
                {
                    //修改数据库
                    Diary diary = await GetDiary();
                    diary.Share = 0;
                    PutDiary(diary);
                    btnShare.Text = "分享";
                }
            }
            else if(btnShare.Text.Equals("分享"))
            {
                DialogResult dr = MessageBox.Show("确定进行分享？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    //修改数据库
                    Diary diary = await GetDiary();
                    diary.Share = 1;
                    PutDiary(diary);
                    btnShare.Text = "已分享";
                }
            }
        }

        private void BtnAddPic_Click(object sender, EventArgs e)
        {
            //添加图片：打开文件管理器，选择图片进行上传

        }

        private async void InitInfo()
        {
            Diary diary = await GetDiary();
            tbTitle.Text = diary.Title;
            rtbDescription.Text = diary.Description;
            if(diary.Share == 1)
            {
                btnShare.Text = "已分享";
            }
            else if(diary.Share == 0)
            {
                btnShare.Text = "分享";
            }
            //缺少图片加载

        }

        private async Task<Diary> GetDiary()
        {
            //根据id获取diary
            string url = this.baseUrl + "/get?diaryid=" + this.DiaryId;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Diary));
            Client client = new Client();
            Diary diary = new Diary();
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    diary = (Diary)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return diary;
        }

        private async void PutDiary(Diary diary)
        {
            string url = this.baseUrl + "/update?diaryid=" + this.DiaryId;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Diary));
            Client client = new Client();
            string data = "";
            try
            {
                using (StringWriter sw = new StringWriter())
                {
                    xmlSerializer.Serialize(sw, diary);
                    data = sw.ToString();
                }
                HttpResponseMessage result = await client.Put(url, data);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
