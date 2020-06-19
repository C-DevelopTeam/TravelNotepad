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

namespace TravelClient.controller
{
    public partial class UC_DiaryCell : UserControl
    {
        public UC_DiaryCell()
        {
            InitializeComponent();
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
                Font SFProFont20 = new Font(font.Families[0], 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                lblTitle.Font = SFProFont20;
                lblTime.Font = SFProFont9;
                label1.Font = SFProFont9;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UC_DiaryCell_Click(object sender, EventArgs e)
        {
            //跳转至日志详情页面
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //删除此条信息
        }
    }
}
