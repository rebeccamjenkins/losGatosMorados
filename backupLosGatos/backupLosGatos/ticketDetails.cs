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
            //this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);
            ticketID.Text = coordinatorDashboard.selectedRow.Cells[0].Value.ToString();
            unitID.Text = coordinatorDashboard.selectedRow.Cells[1].Value.ToString();
            equipmentID.Text = coordinatorDashboard.selectedRow.Cells[2].Value.ToString();
            welderSignature.Text = coordinatorDashboard.selectedRow.Cells[3].Value.ToString();
            inspectorSignature.Text = coordinatorDashboard.selectedRow.Cells[4].Value.ToString();
            additionalInformationTextBox.Text = coordinatorDashboard.selectedRow.Cells[5].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            createUpdate updatePage = new createUpdate();
            updatePage.Show();
        }
    }
}
