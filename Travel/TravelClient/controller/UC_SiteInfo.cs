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
    public partial class UC_SiteInfo : UserControl
    {
        public UC_SiteInfo()
        {
            InitializeComponent();
            UC_Todo uc_todo = new UC_Todo();
            AddControlsToPanel(uc_todo,TodoflowLayoutPanel1);
        }

        private void Btn_backToRoute_Click(object sender, EventArgs e)
        {

        }



        private void AddControlsToPanel(Control c, Panel panel)
        {
            c.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(c);
        }


    }
}
