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
    public partial class UC_Site : UserControl
    {
        ChangePanel changePanel;
        public UC_Site()
        {
            InitializeComponent();
        }

        public UC_Site(ChangePanel changePanel,long routeID=-1)
        {
            InitializeComponent();
            this.changePanel = changePanel;
        }

        private void Btn_ToSiteInfo_Click(object sender, EventArgs e)
        {
            UC_SiteInfo uc_siteInfo = new UC_SiteInfo(changePanel);
            changePanel(uc_siteInfo);
        }
    }
}
