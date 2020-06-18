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
    public partial class UC_PresentTravelList : UserControl
    {
        public UC_PresentTravelList()
        {
            InitializeComponent();
            UC_TravelCell uc_cell = new UC_TravelCell();
            AddControlsToPanel(uc_cell, PanelCell1);
        }

        private void AddControlsToPanel(Control c,Panel panel)
        {
            c.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(c);
        }
    }
}
