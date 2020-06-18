using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelClient.controller;
using TravelClient.form;

namespace TravelClient.controller
{
    public partial class UC_AllSites : UserControl
    {
        ChangePanel changePanel;
        public UC_AllSites()
        {
            InitializeComponent();
            UC_Site uc_site = new UC_Site();
            AddControlsToPanel(uc_site, Sitepanel1);
        }

        public UC_AllSites(ChangePanel changePanel, long travelID=-1)
        {
            InitializeComponent();
            this.changePanel = changePanel;
            UC_Site uc_site = new UC_Site(this.changePanel);
            AddControlsToPanel(uc_site, Sitepanel1);
        }

        private void AddControlsToPanel(Control c, Panel panel)
        {
            c.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(c);
        }
    }
}
