using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelClient.form;

namespace TravelClient.controller
{
    public partial class UC_TravelCell : UserControl
    {
        long travelID;
        ChangePanel changePanel;

        public UC_TravelCell()
        {
            InitializeComponent();
        }

        public UC_TravelCell(ChangePanel changePanel,long ID=-1)
        {
            InitializeComponent();
            this.changePanel = changePanel;
            travelID = ID;
        }

        private void Btn_TravelTitle_Click(object sender, EventArgs e)
        {
            UC_AllSites uc_AllSites = new UC_AllSites(changePanel);
            changePanel(uc_AllSites);
        }

        public void SetFont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\font\造字工房映力黑规体.otf");

                Font titleFont14 = new Font(font.Families[0], 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

                //设置窗体控件字体，哪些控件要更改都写到下面

                Btn_TravelTitle.Font = titleFont14;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
