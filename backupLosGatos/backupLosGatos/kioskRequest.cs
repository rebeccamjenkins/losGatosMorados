using System;
using System.Windows.Forms;

namespace backupLosGatos
{
    public partial class kioskRequest : Form
    {
        public kioskRequest()
        {
            InitializeComponent();
        }

        private void dashboardPage_Click(object sender, EventArgs e)
        {
            managerDashboard managerDashboard = new managerDashboard();
            managerDashboard.Show();
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticketDetails newTicket = new ticketDetails();
            newTicket.Show();
            this.Hide();
        }
    }
}
