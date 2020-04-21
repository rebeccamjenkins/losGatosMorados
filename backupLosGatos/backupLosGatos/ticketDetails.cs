using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace backupLosGatos
{
    public partial class ticketDetails : Form
    {
        public ticketDetails()
        {
            InitializeComponent();
        }

        private void ticketDetails_Load(object sender, EventArgs e)
        {
            //this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);
        }

        private void ticketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gROUP6DataSet);
        }

        private void dashboardPage_Click(object sender, EventArgs e)
        {
            if (coordButton.Enabled == true)
            {
                dashboardScreen pageDashboard = new dashboardScreen();
                pageDashboard.Show();
                this.Close();
            }
            else if (mangButton.Enabled == true)
            {
                managerDashboard pageDashboard = new managerDashboard();
                pageDashboard.Show();
                this.Close();
            }
            else
            {
                technicianDashboard pageDashboard = new technicianDashboard();
                pageDashboard.Show();
                this.Close();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Tickets (unitID, equipmentID, welderSignature, inspectorSignature, additionalInformation, status, priority, dateSubmitted) VALUES ('" + this.unitIDTextBox.Text + "','" + this.equipmentIDTextBox.Text + "','" + this.welderSignatureTextBox.Text + "','" + this.inspectorSignatureTextBox + "','" + this.additionalInformationTextBox.Text + "','" + this.statusComboBox.Text + "','" + this.priorityComboBox.Text + "','" + this.dateSubmittedDateTimePicker.Value + ")'", conn);
            SqlDataReader read;
            try
            {
                conn.Open();
                read = cmd.ExecuteReader();
                MessageBox.Show("New ticket has been created.");
                while (read.Read())
                {
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }
    }
}
