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
using System.Xml.Serialization;
using TravelClient.utils;
using System.Net.Http;

namespace TravelClient.controller
{
    public partial class UC_TravelCell : UserControl
    {
        public long travelID;
        public string travelTiltle;
        public Delegate_init init;

        ChangePanel changePanel;

        public UC_TravelCell()
        {
            InitializeComponent();
        }

        public UC_TravelCell(ChangePanel changePanel,long ID,string title, Delegate_init init)
        {
            InitializeComponent();
            this.changePanel = changePanel;
            travelTiltle = title;
            travelID = ID;
            Btn_TravelTitle.Text = title;
            this.init = init;
            SetFont();
        }

        private void Btn_TravelTitle_Click(object sender, EventArgs e)
        {
            UC_AllSites uc_AllSites = new UC_AllSites(changePanel,travelTiltle,travelID);
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

        private async void Btn_deleteTravel_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:5001/api/Travel/delete?travelId=" + travelID;
            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Delete(url);
                if (result.IsSuccessStatusCode)
                {
                    init();
                }
                else
                {
                    using (Form_Tips tip = new Form_Tips("警告", "初始化信息失败"))
                    {
                        tip.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
