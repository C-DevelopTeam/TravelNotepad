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
using TravelClient.form;
using System.Xml.Serialization;
using TravelClient.Models;
using TravelClient.utils;
using System.Net.Http;

namespace TravelClient.controller
{
    public partial class UC_DiaryCell : UserControl
    {
        private readonly string DiaryId;
        private readonly ChangePanel ChangePanel;
        public Refresh Refresh;
        public UC_DiaryCell(string diaryId, ChangePanel changePanel, Refresh refresh)
        {
            InitializeComponent();
            this.DiaryId = diaryId;
            this.ChangePanel = changePanel;
            this.Refresh = refresh;
            SetFont();
        }

        private void SetFont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\font\造字工房映力黑规体.otf");
                font.AddFontFile(AppPath + @"\font\SF-Pro-Text-Medium.otf");

                Font SFProFont9 = new Font(font.Families[0], 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font SFProFont14 = new Font(font.Families[1], 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font TitleFont9 = new Font(font.Families[1], 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                
                //设置窗体控件字体，哪些控件要更改都写到下面
                lblTitle.Font = SFProFont14;
                lblTime.Font = SFProFont9;
                label1.Font = TitleFont9;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UC_DiaryCell_Click(object sender, EventArgs e)
        {
            //跳转至日志详情页面
            string id = this.DiaryId;
            UC_DiaryDetail uc_DiaryDetail = new UC_DiaryDetail(id, this.ChangePanel);
            this.ChangePanel(uc_DiaryDetail);
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            //删除此条日志
            DialogResult dialogResult = MessageBox.Show("是否确认删除此日志？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(dialogResult == DialogResult.OK)
            {
                string id = this.DiaryId;
                string url = "https://localhost:5001/api/diary/delete?diaryId=" + id;
                Client client = new Client();
                try
                {
                    HttpResponseMessage result = await client.Delete(url);
                    if(!result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("删除未成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n删除失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
