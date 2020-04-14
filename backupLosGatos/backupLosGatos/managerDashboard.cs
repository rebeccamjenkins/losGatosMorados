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
            this.usersTableAdapter.Fill(this.gROUP6DataSet.Users);
            this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);
        }

        private void ticketPage_Click(object sender, EventArgs e)
        {
            ticketDetails newTicket = new ticketDetails();
            newTicket.Show();
            this.Close();
        }

        private void dashboardGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketDetails viewTicket = new ticketDetails();
            viewTicket.ticketIDTextBox.Text = this.dashboardGrid.CurrentRow.Cells[0].Value.ToString();
            viewTicket.unitIDTextBox.Text = this.dashboardGrid.CurrentRow.Cells[1].Value.ToString();
            viewTicket.equipmentIDTextBox.Text = this.dashboardGrid.CurrentRow.Cells[2].Value.ToString();
            viewTicket.dateSubmittedDateTimePicker.Text = this.dashboardGrid.CurrentRow.Cells[3].Value.ToString();
            viewTicket.priorityComboBox.Text = this.dashboardGrid.CurrentRow.Cells[4].Value.ToString();
            viewTicket.statusComboBox.Text = this.dashboardGrid.CurrentRow.Cells[5].Value.ToString();
            viewTicket.welderSignatureTextBox.Text = this.dashboardGrid.CurrentRow.Cells[6].Value.ToString();
            viewTicket.inspectorSignatureTextBox.Text = this.dashboardGrid.CurrentRow.Cells[7].Value.ToString();
            viewTicket.additionalInformationTextBox.Text = this.dashboardGrid.CurrentRow.Cells[8].Value.ToString();

            viewTicket.Show();
            this.Close();
        }
    }
}
