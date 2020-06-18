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
    public partial class UC_TravelList : UserControl
    {
        
        public UC_TravelList()
        {
            InitializeComponent();
            SetFont();
            UC_TravelCell uc_cell = new UC_TravelCell();
            AddCellInfoToPanel(uc_cell, PanelCell1);
            
        }

        public UC_TravelList(ChangePanel changePanel)
        {
            InitializeComponent();
            UC_TravelCell uc_cell = new UC_TravelCell(changePanel);
            AddCellInfoToPanel(uc_cell, PanelCell1);

        }

        private void AddCellInfoToPanel(Control c, Panel panel)
        {
            c.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(c);
            
        }


        private void Btn_addTravel_Click(object sender, EventArgs e)
        {
            using (Form_NewTravel newTravel = new Form_NewTravel())
            {
                newTravel.ShowDialog();
            }
        }

        public void SetFont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\font\造字工房映力黑规体.otf");
                Font titleFont20 = new Font(font.Families[0], 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                Lbl_MyTrip.Font = titleFont20;

            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



    }
}
