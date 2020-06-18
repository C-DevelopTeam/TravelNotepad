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
    public partial class UC_SiteInfo : UserControl
    {
        ChangePanel changePanel;
        public UC_SiteInfo()
        {
            InitializeComponent();
            UC_Todo uc_todo = new UC_Todo();
            AddControlsToPanel(uc_todo,TodoflowLayoutPanel1);
        }

        public UC_SiteInfo(ChangePanel changePanel)
        {
            InitializeComponent();
            this.changePanel = changePanel;
            UC_Todo uc_todo = new UC_Todo();
            AddControlsToPanel(uc_todo, TodoflowLayoutPanel1);
        }

        private void Btn_backToRoute_Click(object sender, EventArgs e)
        {
            UC_AllSites uc_as = new UC_AllSites(changePanel);
            changePanel(uc_as);
        }

        private void AddControlsToPanel(Control c, Panel panel)
        {
            c.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(c);
        }


    }
}
