using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelClient.form;

namespace TravelClient.controller
{
    public partial class UC_TravelCell : UserControl
    {
        long travelID;
        ChangePanel changePanel;

        public UC_TravelCell()
        {
            InitializeComponent();
        }

        public UC_TravelCell(ChangePanel changePanel,long ID=-1)
        {
            InitializeComponent();
            this.changePanel = changePanel;
            travelID = ID;
        }

        private void Btn_TravelTitle_Click(object sender, EventArgs e)
        {
            UC_AllSites uc_AllSites = new UC_AllSites(changePanel);
            changePanel(uc_AllSites);
        }
    }
}
