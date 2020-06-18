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
    public partial class UC_TravelList : UserControl
    {
        
        public UC_TravelList()
        {
            InitializeComponent();
            UC_TravelCell uc_cell = new UC_TravelCell();
            AddCellInfoToPanel(uc_cell, PanelCell1);
            
        }

        public UC_TravelList(ChangePanel changePanel)
        {
            InitializeComponent();
            UC_TravelCell uc_cell = new UC_TravelCell(changePanel);
            AddCellInfoToPanel(uc_cell, PanelCell1);

        }

        private void AddCellInfoToPanel(Control c, Panel panel)
        {
            c.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(c);
        }


        private void Btn_addTravel_Click(object sender, EventArgs e)
        {
            using (Form_NewTravel newTravel = new Form_NewTravel())
            {
                newTravel.ShowDialog();
            }
        }
    }
}
