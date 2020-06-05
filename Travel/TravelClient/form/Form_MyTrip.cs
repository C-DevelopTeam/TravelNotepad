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
    public partial class Form_MyTrip : Form
    {
        int PanelHeight;

        public Form_MyTrip()
        {
            InitializeComponent();
            PanelHeight = panelleft.Height;
        }

        private void moveSlidePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btn_plan);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btn_journal);
            UC_MyJournal mj = new UC_MyJournal();
            AddControlsToPanel(mj);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_todo_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btn_todo);
        }
    }
}
