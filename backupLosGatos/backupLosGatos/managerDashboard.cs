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
            ticketDetails newTicket = new ticketDetails();
            int numRows = dataGridView1.Rows.Count;
            newTicket.ticketIDTextBox.Text = numRows.ToString();
            this.Hide();
            newTicket.Show();

            

        }

        private void dashboardPage_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketDetails viewTicket = new ticketDetails();
            viewTicket.ticketIDTextBox.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            viewTicket.cmbUnit.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            viewTicket.cmbEquipment.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            viewTicket.txtAssigned.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            viewTicket.cmbStatus.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            viewTicket.cmbPriority.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
            viewTicket.ShowDialog();
            this.Close();
        }
    }
}
