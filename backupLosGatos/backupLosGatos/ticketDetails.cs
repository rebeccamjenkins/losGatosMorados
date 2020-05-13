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
            if (coordButton.Enabled == true || mangButton.Enabled == false)
            {
                dashboardScreen pageDashboard = new dashboardScreen();
                pageDashboard.Show();
                this.Close();
            }
            else if (mangButton.Enabled == true || coordButton.Enabled == false)
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
            string unitID = ticketIDText.Text.ToString();
            string equipmentID = unitIDText.Text.ToString();
            string priorityLevel = priorityCombo.Text.ToString();
            DateTime date = DateTime.Today;
            string status = statusCombo.Text.ToString();
            string welder = welderSignatureText.Text.ToString();
            string inspector = inspectorSignatureText.Text.ToString();
            string assignto = associateIDComboBox.Text.ToString();

            string additionalInfo = additionalInformationText.Text.ToString();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit ticket?", "Ticket Submission", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //create data source and static variables
                string connectionString = @"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true";
                SqlConnection con = new SqlConnection(connectionString);
                DateTime thisDay = DateTime.Today;
                int numID = 0;

                //pull number of rows from database in order to create ticketID
                con.Open();
                SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM Tickets", con);
                Int32 count = (Int32)comm.ExecuteScalar();

                con.Close();

                //create strings for all variables
                numID = count + 100;

                /*string unitID = ticketIDText.Text.ToString();
                string equipmentID = unitIDText.Text.ToString();
                string priorityLevel = priorityCombo.Text.ToString();
                 DateTime date = DateTime.Today;
                 string status = statusCombo.Text.ToString();
                 string welder = welderSignatureText.Text.ToString();
                string inspector = inspectorSignatureText.Text.ToString();
                string assignto = associateIDComboBox.Text.ToString();
                string additionalInfo = additionalInformationText.Text.ToString();*/

                using (SqlConnection openCon = new SqlConnection(connectionString))
                {
                    string injection = "INSERT into Tickets (ticketID, unitID, equipmentID, priorityLevel, dateSubmitted, status, welderSignature, employeeName, inspectorSignature, additionalInformation) VALUES (@ticketID,@unitID,@equipmentID,@priorityLevel, @dateSubmitted, @status, @welderSignature, @employeeName, @inspectorSignature, @additionalInfo )";

                    using (SqlCommand command = new SqlCommand(injection))
                    {
                        command.Connection = openCon;
                        command.Parameters.Add("@ticketID", SqlDbType.NVarChar, 50).Value = numID;
                        command.Parameters.Add("@unitID", SqlDbType.NChar, 10).Value = unitID;
                        command.Parameters.Add("@equipmentID", SqlDbType.NChar, 10).Value = equipmentID;
                        command.Parameters.Add("@priorityLevel", SqlDbType.NChar, 10).Value = priorityLevel;
                        command.Parameters.Add("@dateSubmitted", SqlDbType.NChar, 10).Value = date;
                        command.Parameters.Add("@status", SqlDbType.NChar, 10).Value = status;
                        command.Parameters.Add("@welderSignature", SqlDbType.NChar, 10).Value = welder;
                        command.Parameters.Add("@employeeName", SqlDbType.NVarChar, 50).Value = assignto;
                        command.Parameters.Add("@inspectorSignature", SqlDbType.NChar, 10).Value = inspector;
                        command.Parameters.Add("@additionalInfo", SqlDbType.NVarChar, 1000).Value = additionalInfo;

                        openCon.Open();

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Entry Saved");

            }
            //reset app
            else if (dialogResult == DialogResult.No)
            {

            }

            /*DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit ticket?", "Ticket Submission", MessageBoxButtons.YesNo);
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
            }*/
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

        private void ticketPage_Click(object sender, EventArgs e)
        {
            ticketDetails newTicket = new ticketDetails();

            if (coordButton.Enabled == true || mangButton.Enabled == true)
            {
                if (coordButton.Enabled == true)
                { 
                    //makes sure the right permissions are given
                    newTicket.mangButton.Enabled = true;
                    newTicket.coordButton.Enabled = false;

                    //disable the 'create ticket' button
                    newTicket.ticketPage.Visible = false;

                    //this makes it so it autofills the ticket number for us
                    string connectionString = null;
                    SqlConnection connection;
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    string sql = null;

                    connectionString = "Data Source=10.135.85.184;Initial Catalog=Group6;User ID=Group6;Password=Grp6s2117";
                    sql = "SELECT ticketID FROM Tickets";
                    connection = new SqlConnection(connectionString);

                    try
                    {
                        connection.Open();
                        command = new SqlCommand(sql, connection);
                        adapter.SelectCommand = command;
                        adapter.Fill(ds, "SQL Temp Table");
                        adapter.Dispose();
                        command.Dispose();
                        //connection.Close();

                        newTicket.ticketIDText.Text = (ds.Tables[0].Rows.Count + 100).ToString();
                        //MessageBox.Show("Number of row(s) - " + ds.Tables[0].Rows.Count);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot open connection to database!");
                    }
                }
                else
                {
                    newTicket.mangButton.Enabled = false;
                    newTicket.coordButton.Enabled = true;

                    //disable the 'create ticket' button
                    newTicket.ticketPage.Visible = false;

                    //this makes it so it autofills the ticket number for us
                    string connectionString = null;
                    SqlConnection connection;
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    string sql = null;

                    connectionString = "Data Source=10.135.85.184;Initial Catalog=Group6;User ID=Group6;Password=Grp6s2117";
                    sql = "SELECT ticketID FROM Tickets";
                    connection = new SqlConnection(connectionString);

                    try
                    {
                        connection.Open();
                        command = new SqlCommand(sql, connection);
                        adapter.SelectCommand = command;
                        adapter.Fill(ds, "SQL Temp Table");
                        adapter.Dispose();
                        command.Dispose();
                        //connection.Close();

                        newTicket.ticketIDText.Text = (ds.Tables[0].Rows.Count + 100).ToString();
                        //MessageBox.Show("Number of row(s) - " + ds.Tables[0].Rows.Count);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot open connection to database!");
                    }
                }

                newTicket.Show();
                this.Hide();
            }
        }
    }
}
