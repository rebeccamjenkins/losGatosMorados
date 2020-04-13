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
    public partial class ticketDetails : Form
    {
        public ticketDetails()
        {
            InitializeComponent();
        }

        private void ticketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gROUP6DataSet);
        }

        private void ticketDetails_Load(object sender, EventArgs e)
        {
            this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);
        }

        private void ticketPage_Click(object sender, EventArgs e)
        {
            managerDashboard findTicket = new managerDashboard();
            this.Hide();
            findTicket.Show();
        }
    }
}
