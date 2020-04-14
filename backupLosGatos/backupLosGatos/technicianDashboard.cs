using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backupLosGatos
{
    public partial class technicianDashboard : Form
    {
        public technicianDashboard()
        {
            InitializeComponent();
        }

        private void technicianDashboard_Load(object sender, EventArgs e)
        {

        }

        private void ticketPage_Click(object sender, EventArgs e)
        {
            ticketDetails newTicket = new ticketDetails();
            newTicket.Show();
            this.Hide();
        }
    }
}
