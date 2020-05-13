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

            SqlConnection conn = null;
            SqlDataReader reader = null;
            conn = new
            SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");
            conn.Open();

            //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tickets", conn);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //dashboardGrid.DataSource = data;
            //conn.Close();

            //status dropdown
            //conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT status FROM dbo.Tickets", conn);
            reader = cmd.ExecuteReader();
            DataSet dsstatus = new DataSet();
            DataTable dtstatus = new DataTable("Table1");
            dsstatus.Tables.Add(dtstatus);
            dsstatus.Load(reader, LoadOption.PreserveChanges, dsstatus.Tables[0]);

            statusCombo.ValueMember = "status";
            statusCombo.DisplayMember = "status";
            statusCombo.DataSource = dsstatus.Tables[0];
            statusCombo.SelectedIndex = 0;
            statusCombo.SelectedValue = 0;

            //assignee dropdown
            SqlCommand a_cmd = new SqlCommand("SELECT DISTINCT username FROM Users", conn);
            reader = a_cmd.ExecuteReader();
            DataSet dsname = new DataSet();
            DataTable dtname = new DataTable("Table 2");
            dsname.Tables.Add(dtname);
            dsname.Load(reader, LoadOption.PreserveChanges, dsname.Tables[0]);

            associateIDComboBox.ValueMember = "username";
            associateIDComboBox.DisplayMember = "username";
            associateIDComboBox.DataSource = dsname.Tables[0];
            associateIDComboBox.SelectedIndex = 0;
            associateIDComboBox.SelectedValue = 0;

            //equipmentdropdown
            SqlCommand e_cmd = new SqlCommand("SELECT DISTINCT equipmentDescription FROM Equipment", conn);
            reader = e_cmd.ExecuteReader();
            DataSet dsequip = new DataSet();
            DataTable dtequip = new DataTable("Table 3");
            dsequip.Tables.Add(dtequip);
            dsequip.Load(reader, LoadOption.PreserveChanges, dsequip.Tables[0]);

            equipmentCombo.ValueMember = "equipmentDescription";
            equipmentCombo.DisplayMember = "equipmentDescription";
            equipmentCombo.DataSource = dsequip.Tables[0];
            equipmentCombo.SelectedIndex = 0;
            equipmentCombo.SelectedValue = 0;

            //priority dropdown
            SqlCommand p_cmd = new SqlCommand("SELECT DISTINCT priorityLevel FROM Tickets", conn);
            reader = p_cmd.ExecuteReader();
            DataSet dsprior = new DataSet();
            DataTable dtprior = new DataTable("Table 4");
            dsprior.Tables.Add(dtprior);
            dsprior.Load(reader, LoadOption.PreserveChanges, dsprior.Tables[0]);

            priorityCombo.ValueMember = "priorityLevel";
            priorityCombo.DisplayMember = "priorityLevel";
            priorityCombo.DataSource = dsprior.Tables[0];
            priorityCombo.SelectedIndex = 0;
            priorityCombo.SelectedValue = 0;
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
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@dateSubmitted", thisDay);
                cmd.Parameters.AddWithValue("@ticketID", ticketIDText.Text.ToString());
                cmd.Parameters.AddWithValue("@unitID", unitIDText.Text.ToString());
                cmd.Parameters.AddWithValue("@equipmentID", equipmentCombo.SelectedValue.ToString()); 
                cmd.Parameters.AddWithValue("@priorityLevel", priorityCombo.Text.ToString());
                cmd.Parameters.AddWithValue("@welderSignature", welderSignatureText.Text.ToString()); 
                cmd.Parameters.AddWithValue("@inspectorSignature", inspectorSignatureText.Text.ToString()); 
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

        }
    }
}
