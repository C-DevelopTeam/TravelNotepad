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
    public partial class UC_SiteInfo : UserControl
    {
        ChangePanel changePanel;
        long routeID;
        public UC_SiteInfo()
        {
            InitializeComponent();
            SetFont();
            UC_Todo uc_todo = new UC_Todo();
            AddControlsToPanel(uc_todo,TodoflowLayoutPanel1);
        }

        public UC_SiteInfo(ChangePanel changePanel,long routeID = -1,bool isCreate = false)
        {
            InitializeComponent();
            SetFont();
            this.routeID = routeID;
            this.changePanel = changePanel;
            UC_Todo uc_todo = new UC_Todo();
            AddControlsToPanel(uc_todo, TodoflowLayoutPanel1);
        }

        public void SetFont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\font\造字工房映力黑规体.otf");
                Font titleFont20 = new Font(font.Families[0], 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font titleFont12 = new Font(font.Families[0], 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                Lbl_site.Font = titleFont12;
                Lbl_timeForArrive.Font = titleFont12;
                Lbl_timeForLeave.Font = titleFont12;
                Lbl_title.Font = titleFont20;
                Lbl_vehicle.Font = titleFont12;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_backToRoute_Click(object sender, EventArgs e)
        {
            UC_AllSites uc_as = new UC_AllSites(changePanel);
            changePanel(uc_as);
        }

        private void AddControlsToPanel(Control c, Panel panel)
        {
            c.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(c);
        }


        private void Btn_addSite_Click(object sender, EventArgs e)
        {
            UC_SiteInfo newsite = new UC_SiteInfo();
            changePanel(newsite);
        }
    }
}
