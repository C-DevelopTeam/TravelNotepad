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
    public partial class UC_TravelCell : UserControl
    {
        long travelID;

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public delegate void DelegateForTravelcell(object sender, EventArgs e);
        public event DelegateForTravelcell U_cellClick;

        public UC_TravelCell()
        {
            InitializeComponent();
        }

        public UC_TravelCell(long ID)
        {
            InitializeComponent();
            travelID = ID;
        }

        private void Btn_TravelTitle_Click(object sender, EventArgs e)
        {
            if(U_cellClick!=null)
            {
                U_cellClick(sender, e);
            }
        }
    }
}
