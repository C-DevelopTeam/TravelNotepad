using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelClient.controller;

namespace TravelClient.form
{
    public partial class Form_CreateTrip : Form
    {
        int PanelWidth;

        public Form_CreateTrip()
        {
            InitializeComponent();
            PanelWidth = paneltop.Width;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            dateTimePicker1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void moveSlidePanel(Control btn)
        {
            panelSlide.Left = btn.Left;
            panelSlide.Width = btn.Width;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveSlidePanel(buttonct);
            UC_CreateTrip ct = new UC_CreateTrip();
            AddControlsToPanel(ct);
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btn_tdList_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btn_tdList);
            UC_TodoLIst tdl = new UC_TodoLIst();
            AddControlsToPanel(tdl);
        }

        private void btn_journal_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btn_journal);
        }
    }
}
