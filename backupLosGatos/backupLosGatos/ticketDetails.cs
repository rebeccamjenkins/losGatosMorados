using System;
using System.Windows.Forms;

namespace backupLosGatos
{
    public partial class ticketDetails : Form
    {
        private System.Windows.Forms.DataGridView datagrid = new DataGridView();
        int _ticketID = -1;
        public ticketDetails(int i)
        {
            InitializeComponent();
            _ticketID = 1;
        }

        private void ticketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.TicketsBindingSource.EndEdit();
            this.TableAdapterManager.UpdateAll(this.gROUP6DataSet);
        }

        private void ticketDetails_Load(object sender, EventArgs e)
        {
            this.equipmentTableAdapter.Fill(this.gROUP6DataSet.Equipment);
            this.ticketsTableAdapter1.Fill(this.gROUP6DataSet.Tickets);

            ticketID.Text = _ticketID.ToString();
            unitID.Text = _ticketID.ToString();
            equipmentID.Text = _ticketID.ToString();
            welderSignature.Text = _ticketID.ToString();
            inspectorSignature.Text = _ticketID.ToString();
            additionalInformationTextBox.Text = _ticketID.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            createUpdate updatePage = new createUpdate();
            updatePage.Show();
        }

        private void equipmentID_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
