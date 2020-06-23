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
using System.Drawing.Drawing2D;

namespace TravelClient.controller
{
    public partial class UC_DiaryDetail : UserControl
    {
        private readonly string DiaryId;
        private readonly ChangePanel ChangePanel;
        private readonly string baseUrl = "https://localhost:5001/api/diary";
        private Refresh refresh;
        public UC_DiaryDetail(string diaryId, ChangePanel changePanel)
        {
            InitializeComponent();
            this.DiaryId = diaryId;
            this.ChangePanel = changePanel;
            this.refresh = ImgRefresh;
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
                //font.AddFontFile(AppPath + @"\font\SF-Pro-Text-Medium.otf");

                Font titleFont = new Font(font.Families[0], 25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font btnFont = new Font(font.Families[0], 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font textFont = new Font(font.Families[0], 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
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

        private async void BtnBack_Click(object sender, EventArgs e)
        {
            //回退
            Diary diary = await GetDiary();
            UC_DiaryList uc_DiaryList = new UC_DiaryList(diary.Uid.ToString(), this.ChangePanel);
            this.ChangePanel(uc_DiaryList);
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            //保存修改
            tbTitle.Enabled = false;
            btnSave.Enabled = false;
            btnAddPic.Enabled = false;
            rtbDescription.Enabled = false;
            //将修改传到远端
            Diary diary = await GetDiary();
            diary.Title = tbTitle.Text;
            diary.Description = rtbDescription.Text;
            if (await PutDiary(diary))
            {
                using (Form_Tips tip = new Form_Tips("提示", "修改成功"))
                {
                    tip.ShowDialog();
                }
                
            }
            //将编辑激活
            btnEdit.Enabled = true;
            btnEdit.Text = "编辑";
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //启用编辑
            btnEdit.Enabled = false;
            btnEdit.Text = "编辑中";
            tbTitle.Enabled = true;
            btnSave.Enabled = true;
            btnAddPic.Enabled = true;
            rtbDescription.Enabled = true;
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
                    if (await PutDiary(diary))
                    {
                        using (Form_Tips tip = new Form_Tips("提示", "修改成功"))
                        {
                            tip.ShowDialog();
                        }
                    }
                    btnShare.Text = "分享";
                }
            }
            else if(btnShare.Text.Equals("分享"))
            {
                DialogResult dr;
                using (Form_Tips tip = new Form_Tips("提示", "确定进行分享？"))
                {
                    tip.ShowDialog();
                    dr = tip.DialogResult;
                }
                if (dr == DialogResult.Yes)
                {
                    //修改数据库
                    Diary diary = await GetDiary();
                    diary.Share = 1;
                    if(await PutDiary(diary))
                    {
                        using (Form_Tips tip = new Form_Tips("提示", "修改成功"))
                        {
                            tip.ShowDialog();
                        }
                        
                    }
                    btnShare.Text = "已分享";
                }
            }
        }

        private async void BtnAddPic_Click(object sender, EventArgs e)
        {
            string filePath = "";
            FileClient fileClient = new FileClient();
            //添加图片：打开文件管理器，选择图片进行上传
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择上传的图片";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "图片文件|*.jpg;*.gif;*.jpeg;*.png";
            openFileDialog.RestoreDirectory = true;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = Path.GetFullPath(openFileDialog.FileName);
            }
            try
            {
                if(await fileClient.Upload(this.DiaryId, filePath))
                {
                    using (Form_Tips tip = new Form_Tips("提示", "上传成功"))
                    {
                        tip.ShowDialog();
                    }
                    ImgRefresh();
                }
                else
                {
                    using (Form_Tips tip = new Form_Tips("提示", "上传失败"))
                    {
                        tip.ShowDialog();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"上传失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void InitInfo()
        {
            Diary diary = await GetDiary();
            tbTitle.Enabled = false;
            btnAddPic.Enabled = false;
            btnSave.Enabled = false;
            rtbDescription.Enabled = false;
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
            LoadImg(diary.Photo);
        }

        private async void LoadImg(string photo)
        {
            panelImgList.Controls.Clear();
            if (photo != null)
            {
                string[] imgNames = photo.Trim().Split(' ');
                string baseurl = "https://localhost:5001/api/file/download?filename=";
                UC_PicBox pb;
                Image image;
                FileClient fileClient = new FileClient();
                foreach (string name in imgNames)
                {
                    string url = baseurl + name;
                    pb = new UC_PicBox(this.DiaryId, name, this.refresh);
                    image = await fileClient.Download(url);
                    if (image != null)
                    {
                        pb.picBox.Image = ResizeImage(image, new Size(200, 200));
                        pb.Anchor = AnchorStyles.None;
                        panelImgList.Controls.Add(pb);
                    }
                }
            }
        }

        private async void ImgRefresh()
        {
            Diary diary = await GetDiary();
            LoadImg(diary.Photo);
        }

        private async Task<Diary> GetDiary()
        {
            //根据id获取diary
            string url = this.baseUrl + "/get?diaryId=" + this.DiaryId;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Diary));
            Client client = new Client();
            Diary diary = null;
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

        private async Task<bool> PutDiary(Diary diary)
        {
            string url = this.baseUrl + "/update?diaryId=" + this.DiaryId;
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
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private Image ResizeImage(Image imgToResize, Size size)
        {
            //获取图片宽度
            int sourceWidth = imgToResize.Width;
            //获取图片高度
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //计算宽度的缩放比例
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //计算高度的缩放比例
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //期望的宽度
            int destWidth = (int)(sourceWidth * nPercent);
            //期望的高度
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //绘制图像
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (Image)b;
        }
    }
}
