using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelClient.form
{
    public partial class Form_NewTravel : Form
    {
        public string travelTitle;
        public string cityOfTravel;

        public Form_NewTravel()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
           this.Dispose();
        }

        private void Btn_ConfirmToCreate_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
