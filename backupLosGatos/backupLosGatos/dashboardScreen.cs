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
    public partial class dashboardScreen : Form
    {
        public dashboardScreen()
        {
            InitializeComponent();
        }

        private void dashboardScreen_Load(object sender, EventArgs e)
        {
            //this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);
            //this.securityTableAdapter.Fill(this.gROUP6DataSet.Security);
        }

        private void pageOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MenuStrip dashboard = new MenuStrip();
            this.MainMenuStrip = dashboard;
            Controls.Add(dashboard);
        }

        private void dashboardPage_Click(object sender, EventArgs e)
        {
            dashboardScreen pageDashboard = new dashboardScreen();
            pageDashboard.Show();
            this.Close();
        }

        private void ticketPage_Click(object sender, EventArgs e)
        {
            ticketDetails newTicket = new ticketDetails();
            this.Hide();
            newTicket.Show();
        }

    }
}
