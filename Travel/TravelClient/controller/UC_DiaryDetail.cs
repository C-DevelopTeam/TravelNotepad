using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelClient.controller
{
    public partial class UC_DiaryDetail : UserControl
    {
        private readonly string DiaryId;
        public UC_DiaryDetail()
        {
            InitializeComponent();
        }
        public UC_DiaryDetail(string diaryId)
        {
            InitializeComponent();
            this.DiaryId = diaryId;
        }
    }
}
