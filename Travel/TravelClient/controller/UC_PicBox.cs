using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelClient.utils;

namespace TravelClient.controller
{
    public partial class UC_PicBox : UserControl
    {
        private readonly string FileName;
        private readonly string DiaryId;
        private Refresh Refresh;
        private readonly string baseUrl = "https://localhost:5001/api/file/delete?diaryId={0}&fileName={1}";
        public UC_PicBox(string diaryId, string fileName, Refresh r)
        {
            InitializeComponent();
            this.DiaryId = diaryId;
            this.FileName = fileName;
            this.Refresh = r;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string url = string.Format(baseUrl, this.DiaryId, this.FileName);
            FileClient fileClient = new FileClient();
            fileClient.Delete(url);
            this.Refresh();
        }
    }
}
