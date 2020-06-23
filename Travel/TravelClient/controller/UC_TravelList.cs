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
using TravelClient.Models;
using System.Net.Http;

namespace TravelClient.controller
{
    public delegate void Delegate_init();

    public partial class UC_TravelList : UserControl
    {
        int Uid;
        public Delegate_init init;
        ChangePanel changePanel;

        public UC_TravelList(ChangePanel changePanel,int Uid)
        {
            InitializeComponent();
            this.changePanel = changePanel;
            this.Uid = Uid;
            SetFont();
            InitInfo();
        }

        private void AddCellInfoToPanel(Control c, Panel panel)
        {
            c.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(c);
            
        }


        private void Btn_addTravel_Click(object sender, EventArgs e)
        {
            using (Form_NewTravel newTravel = new Form_NewTravel(Uid,init))
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
                Font titleFont12 = new Font(font.Families[0], 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                //设置窗体控件字体，哪些控件要更改都写到下面
                Lbl_MyTrip.Font = titleFont20;

            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public async void InitInfo()
        {
            int id = this.Uid;
            string url = "https://localhost:5001/api/Travel/get?uid=" + id;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Travel>));
            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    List<Travel> travels = (List<Travel>)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                    flowLayoutPanel_travels .Controls.Clear();

                    foreach (Travel Travel in travels)
                    {
                        UC_TravelCell cell = new UC_TravelCell(changePanel,Travel.TravelId, Travel.Description,init);
                        //添加到panel中
                        flowLayoutPanel_travels.Controls.Add(cell);
                    }
                    //添加底部标志

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
