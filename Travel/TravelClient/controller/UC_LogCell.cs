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

namespace TravelClient.controller
{
    public partial class UC_LogCell : UserControl
    {
        private readonly ChangePanel ChangePanel;
        private readonly string DiaryId;
        public UC_LogCell(string diaryId, ChangePanel changePanel)
        {
            InitializeComponent();
            this.DiaryId = diaryId;
            this.ChangePanel = changePanel;
            SetFont();
        }

        private void SetFont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\font\造字工房映力黑规体.otf");

                Font SFProFont9 = new Font(font.Families[0], 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font SFProFont20 = new Font(font.Families[0], 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                lblTitle.Font = SFProFont20;
                lblUserName.Font = SFProFont9;
                lblTime.Font = SFProFont9;
                label2.Font = SFProFont9;
                label3.Font = SFProFont9;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UC_LogCell_Click(object sender, EventArgs e)
        {
            //跳转到日志的详情界面
            string id = this.DiaryId;
            UC_DiaryDetail uc_DiaryDetail = new UC_DiaryDetail(id, this.ChangePanel);
            this.ChangePanel(uc_DiaryDetail);
        }
    }
}
