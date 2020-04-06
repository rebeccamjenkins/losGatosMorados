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
    public partial class managerDashboard : Form
    {
        public managerDashboard()
        {
            InitializeComponent();
        }

        private void managerDashboard_Load(object sender, EventArgs e)
        {
            this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);
        }

        private void ticketPage_Click(object sender, EventArgs e)
        {
            //dashboardScreen dashboard = new dashboardScreen();
            ticketDetails ticketDetails = new ticketDetails();
            //this.Hide();
            //ticketDetails.Show();

        }

        private void dashboardPage_Click(object sender, EventArgs e)
        {

        }
    }
}
