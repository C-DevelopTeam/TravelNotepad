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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml;

namespace TravelClient.controller
{
    public partial class UC_Personalinfo : UserControl
    {
        public UC_Personalinfo()
        {
            InitializeComponent();
            SetFont();
            InitInfo();
        }

        public void SetFont()
        {
            string AppPath = Application.StartupPath;
            try
            {
                PrivateFontCollection font = new PrivateFontCollection();
                font.AddFontFile(AppPath + @"\font\造字工房映力黑规体.otf");

                Font titleFont = new Font(font.Families[0], 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                //设置窗体控件字体，哪些控件要更改都写到下面
                label1.Font = titleFont;
                label2.Font = titleFont;
                label3.Font = titleFont;
                label4.Font = titleFont;
                lblUserId.Font = titleFont;
                btnCommit.Font = titleFont;
            }
            catch
            {
                MessageBox.Show("字体不存在或加载失败\n程序将以默认字体显示", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InitInfo()
        {
            //初始化相关信息

        }

        private void BtnCommit_Click(object sender, EventArgs e)
        {
            //进行代码提交
            string baseUrl = "https://localhost:5001/api/todo";

            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = delegate { return true; };
            HttpClient client = new HttpClient(handler);

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
        }
    }
}
