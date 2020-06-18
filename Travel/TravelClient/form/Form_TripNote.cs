using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelClient.controller;

namespace TravelClient.form
{
    public partial class Form_TripNote : Form
    {
        private Point formPoint = new Point();

        public Form_TripNote()
        {
            InitializeComponent();
            SetFont();
        }

        public void SetFont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\font\JOKERMAN.TTF");//字体的路径及名字
                font.AddFontFile(AppPath + @"\font\SF-Pro-Text-Medium.otf");

                Font jokermanFont25 = new Font(font.Families[0], 25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font titleFont15 = new Font(font.Families[1], 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                Lbl_mytrip.Font = jokermanFont25;
                Btn_MyTravel.Font = titleFont15;
                Btn_NoteSharing.Font = titleFont15;
                Btn_PersonalInfo.Font = titleFont15;
                Btn_presentTravel.Font = titleFont15;
                Btn_TravelNote.Font = titleFont15;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void Btn_MyTravel_Click(object sender, EventArgs e)
        {
            UC_TravelList uc_Present = new UC_TravelList();
            AddControlsToPanel(uc_Present);
        }


        private void Btn_PersonalInfo_Click(object sender, EventArgs e)
        {
            UC_Personalinfo uc_Personalinfo = new UC_Personalinfo();
            AddControlsToPanel(uc_Personalinfo);
        }

        private void Btn_presentTravel_Click(object sender, EventArgs e)
        {
            UC_AllSites uc_allsite = new UC_AllSites();
            AddControlsToPanel(uc_allsite);
        }
    }
}
