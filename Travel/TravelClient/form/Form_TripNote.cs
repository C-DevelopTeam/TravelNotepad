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
    public delegate void ChangePanel(Control c);

    public partial class Form_TripNote : Form
    {
        private Point formPoint = new Point();
        public ChangePanel changePanel;
        int Uid;

        public Form_TripNote(int Uid)
        {
            InitializeComponent();
            this.Uid = Uid;
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

                Font jokermanFont16 = new Font(font.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                Font titleFont11 = new Font(font.Families[1], 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                Lbl_mytrip.Font = jokermanFont16;
                Btn_MyTravel.Font = titleFont11;
                Btn_NoteSharing.Font = titleFont11;
                Btn_PersonalInfo.Font = titleFont11;
                Btn_presentTravel.Font = titleFont11;
                Btn_TravelNote.Font = titleFont11;
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

        public void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }


        private void Btn_MyTravel_Click(object sender, EventArgs e)
        {
            UC_TravelList uc_Present = new UC_TravelList(changePanel,Uid);
            AddControlsToPanel(uc_Present);
        }


        private void Btn_PersonalInfo_Click(object sender, EventArgs e)
        {
            //此处uid应该是从mainPage传输过来，现在整体尚未搭建完毕，先暂定为0
            UC_Personalinfo uc_Personalinfo = new UC_Personalinfo(Uid.ToString());
            AddControlsToPanel(uc_Personalinfo);
        }

        private void Btn_presentTravel_Click(object sender, EventArgs e)
        {
            UC_AllSites uc_allsite = new UC_AllSites(changePanel);
            AddControlsToPanel(uc_allsite);
        }

        private void Btn_NoteSharing_Click(object sender, EventArgs e)
        {
            //此处uid应该是从mainPage传输过来，现在整体尚未搭建完毕，先暂定为0
            UC_LogCircle uc_LogCircle = new UC_LogCircle(Uid.ToString(), changePanel);
            AddControlsToPanel(uc_LogCircle);
        }

        private void Btn_TravelNote_Click(object sender, EventArgs e)
        {
            //此处uid应该是从mainPage传输过来，现在整体尚未搭建完毕，先暂定为0
            UC_DiaryList uc_DiaryList = new UC_DiaryList(Uid.ToString(), changePanel);
            AddControlsToPanel(uc_DiaryList);
        }
    }
}
