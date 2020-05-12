using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            //this.usersTableAdapter.Fill(this.gROUP6DataSet.Users);
            //this.equipmentTableAdapter.Fill(this.gROUP6DataSet.Equipment);
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
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit ticket?", "Ticket Submission", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");
                DateTime thisDay = DateTime.Today;
                int numID = 0;

                SqlCommand cmd = new SqlCommand("sp_insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dateSubmitted", thisDay);
                cmd.Parameters.AddWithValue("@ticketID", ticketIDText.Text.ToString());
                cmd.Parameters.AddWithValue("@unitID", unitIDText.Text.ToString());
                cmd.Parameters.AddWithValue("@equipmentID", equipmentCombo.SelectedValue.ToString()); //needs to display equipment names in the combobox while processing them as the equipmentID
                cmd.Parameters.AddWithValue("@priorityLevel", priorityCombo.Text.ToString());
                //cmd.Parameters.AddWithValue("@associateID", assignedCombo.Text.ToString()); //needs to display names in the combobox while processing the selection as the associateID 
                    //we need to code how to create an assignmentID automatically when a ticketID and associateID are provided. all three of them comprise a composite key, so they're all required. i wonder if this is similar to michelle's auto-incrementing ticket number code?
                cmd.Parameters.AddWithValue("@welderSignature", welderSignatureText.Text.ToString()); //double check this allows for nulls
                cmd.Parameters.AddWithValue("@inspectorSignature", inspectorSignatureText.Text.ToString()); //double check this allows for nulls
                cmd.Parameters.AddWithValue("@additionalInformation", additionalInformationText.Text.ToString());

                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();

                if (i != 0)
                {
                    MessageBox.Show("Your ticket has been submitted.");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                unitIDText.Text = "";
                priorityCombo.SelectedIndex = -1;
                priorityCombo.Enabled = false;
                equipmentCombo.Enabled = false;
                //associateCombo.Enabled = false;
                welderSignatureText.Text = "";
                inspectorSignatureText.Text = "";
                additionalInformationText.Text = "";
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
  
        }

        private void viewKioskRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kioskRequest openRequests = new kioskRequest();

            if (coordButton.Enabled == true || mangButton.Enabled == true)
            {
                if (coordButton.Enabled == true)
                {
                    openRequests.coordButton.Enabled = true;
                    openRequests.mangButton.Enabled = false;
                }
                else
                {
                    openRequests.coordButton.Enabled = false;
                    openRequests.mangButton.Enabled = true;
                }
                openRequests.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry, you do not have the needed permissions to access this page.");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginScreen newLogin = new loginScreen();
            newLogin.Show();
            this.Close();
        }

        private void unitIDText_TextChanged(object sender, EventArgs e)
        {
            equipmentCombo.Enabled = true;
            equipmentCombo.Items.Clear();
            equipmentCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            if (unitIDText.Text == "1")
            {
                equipmentCombo.Items.Add(1);
                equipmentCombo.Items.Add(2);
                equipmentCombo.Items.Add(3);
                equipmentCombo.Items.Add(4);
            }
            if (unitIDText.Text == "2")
            {
                equipmentCombo.Items.Add(5);
                equipmentCombo.Items.Add(6);
                equipmentCombo.Items.Add(7);
                equipmentCombo.Items.Add(8); ;
            }
            if (unitIDText.Text == "3")
            {
                equipmentCombo.Items.Add(9);
                equipmentCombo.Items.Add(10);
                equipmentCombo.Items.Add(11);
                equipmentCombo.Items.Add(12);
            }
            if (unitIDText.Text == "4")
            {
                equipmentCombo.Items.Add(13);
                equipmentCombo.Items.Add(14);
                equipmentCombo.Items.Add(15);
                equipmentCombo.Items.Add(16);
            }
        }
    }
}
