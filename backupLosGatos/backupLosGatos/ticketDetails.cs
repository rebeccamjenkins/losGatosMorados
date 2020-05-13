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
            string unitID = unitIDText.Text.ToString();
            string equipmentID = equipmentCombo.Text.ToString();
            string priorityLevel = priorityCombo.Text.ToString();
            DateTime date = DateTime.Today;
            string status = statusCombo.Text.ToString();
            if (status == "Not Starte")
            {
                status = statusCombo.Text.ToString() + "d";
            }
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

                //check to make sure they do not have more than three tickets assigned
                SqlCommand technician = new SqlCommand("SELECT COUNT(*) FROM Tickets WHERE userName = '" +
                    assignto + "' AND (status = 'Not Started' OR status = 'Not Starte' OR status = 'In Progress')", con);
                Int32 ticketCount = (Int32)technician.ExecuteScalar();
                MessageBox.Show(ticketCount.ToString());
                if (ticketCount < 3)
                {
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
                        string injection = "INSERT into Tickets (ticketID, unitID, equipmentID, priorityLevel, dateSubmitted, status, welderSignature, userName, inspectorSignature, additionalInformation) VALUES (@ticketID,@unitID,@equipmentID,@priorityLevel, @dateSubmitted, @status, @welderSignature, @userName, @inspectorSignature, @additionalInfo )";

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
                            command.Parameters.Add("@userName", SqlDbType.NVarChar, 50).Value = assignto;
                            command.Parameters.Add("@inspectorSignature", SqlDbType.NChar, 10).Value = inspector;
                            command.Parameters.Add("@additionalInfo", SqlDbType.NVarChar, 1000).Value = additionalInfo;

                            openCon.Open();

                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Entry Saved");
                    associateIDComboBox.Text = null;
                    unitIDText.Text = null;
                    equipmentCombo.Text = null;
                    statusCombo.Text = null;
                    priorityCombo.Text = null;
                    additionalInformationText.Text = null;
                }
                else
                {
                    MessageBox.Show("This technician has reached the maximum amount of tickets allowed to " +
                        "be assigned to them. Please assign another available technician.");
                    associateIDComboBox.Text = null;
                    ticketIDText.Text = ticketIDText.Text + 1;
                }
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
            submitButton.Visible = false;
            saveButton.Visible = true;

            welderSignatureText.ReadOnly = false;
            inspectorSignatureText.ReadOnly = false;
            additionalInformationText.ReadOnly = false;
            unitIDText.ReadOnly = false;

            assignText.Visible = false;
            associateIDComboBox.Visible = true;
            associateIDComboBox.Text = assignText.Text;

            priorityText.Visible = false;
            priorityCombo.Visible = true;
            priorityCombo.Text = priorityText.Text;

            statusText.Visible = false;
            statusCombo.Visible = true;
            statusCombo.Text = statusText.Text;

            //dateText.Visible = false;
            //dateTimePicker.Visible = true;
            //dateTimePicker.Value = dateText.Text;

            equipText.Visible = false;
            equipmentCombo.Visible = true;
            equipmentCombo.Text = equipText.Text;

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
            //ticketDetails newTicket = new ticketDetails();
            submitButton.Visible = true;
            saveButton.Visible = false;
            updateButton.Visible = false;

            welderSignatureText.ReadOnly = false;
            welderSignatureText.Text = null;
            inspectorSignatureText.ReadOnly = false;
            inspectorSignatureText.Text = null;
            additionalInformationText.ReadOnly = false;
            additionalInformationText.Text = null;
            unitIDText.ReadOnly = false;
            unitIDText.Text = null;
            

            assignText.Visible = false;
            associateIDComboBox.Visible = true;

            priorityText.Visible = false;
            priorityCombo.Visible = true;

            statusText.Visible = false;
            statusCombo.Visible = true;

            dateText.Visible = false;
            dateTimePicker.Visible = true;

            equipText.Visible = false;
            equipmentCombo.Visible = true;


            //disable the 'create ticket' button
            ticketPage.Visible = false;

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

                ticketIDText.Text = (ds.Tables[0].Rows.Count + 100).ToString();
                //MessageBox.Show("Number of row(s) - " + ds.Tables[0].Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection to database!");
            }

            if (coordButton.Enabled == true || mangButton.Enabled == true)
            {
                if (coordButton.Enabled == true)
                { 
                    //makes sure the right permissions are given
                    mangButton.Enabled = false;
                    coordButton.Enabled = true;
                }
                else
                {
                    mangButton.Enabled = true;
                    coordButton.Enabled = false;

                }

                //newTicket.Show();
                //this.Hide();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string ticketID = ticketIDText.Text;
            string tempAssign = associateIDComboBox.Text;
            string tempPriority = priorityCombo.Text;
            string tempStatus = statusCombo.Text;
            string tempEquip = equipmentCombo.Text;
            string tempWelder = welderSignatureText.Text;
            string tempInspector = inspectorSignatureText.Text;
            string tempAdditionalInfo = additionalInformationText.Text;
            string tempUnit = unitIDText.Text;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this ticket?", "Update Ticket", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //create data source and static variables
                string connectionString = @"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true";
                SqlConnection con = new SqlConnection(connectionString);
                //DateTime thisDay = DateTime.Today;
                //int numID = 0;

                //pull number of rows from database in order to create ticketID
                //con.Open();
                //SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM Tickets", con);
                //Int32 count = (Int32)comm.ExecuteScalar();
                //con.Close();

                using (SqlConnection openCon = new SqlConnection(connectionString))
                {
                    string update = "UPDATE Tickets SET userName = @userName, priorityLevel = @priorityLevel, " +
                        "status = @status, dateSubmitted = @dateSubmitted, equipmentID = @equipmentID, " +
                        "welderSignature = @welderSignature, inspectorSignature = @inspectorSignature," +
                        "additionalInfo = @additionalInfo, unitID = @unitID WHERE ticketID = @ticketID; ";

                    using (SqlCommand command = new SqlCommand(update))
                    {
                        command.Connection = openCon;
                        command.Parameters.Add("@ticketID", SqlDbType.NVarChar, 50).Value = ticketID;
                        command.Parameters.Add("@unitID", SqlDbType.NChar, 10).Value = tempUnit;
                        command.Parameters.Add("@equipmentID", SqlDbType.NChar, 10).Value = tempEquip;
                        command.Parameters.Add("@priorityLevel", SqlDbType.NChar, 10).Value = tempPriority;
                        //command.Parameters.Add("@dateSubmitted", SqlDbType.NChar, 10).Value = ;
                        command.Parameters.Add("@status", SqlDbType.NChar, 10).Value = tempStatus;
                        command.Parameters.Add("@welderSignature", SqlDbType.NChar, 10).Value = tempWelder;
                        command.Parameters.Add("@userName", SqlDbType.NVarChar, 50).Value = tempAssign;
                        command.Parameters.Add("@inspectorSignature", SqlDbType.NChar, 10).Value = tempInspector;
                        command.Parameters.Add("@additionalInfo", SqlDbType.NVarChar, 1000).Value = tempAdditionalInfo;

                        openCon.Open();

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ticket updated.");

                if (mangButton.Enabled = true)
                {
                    managerDashboard openManager = new managerDashboard();
                    openManager.Show();
                    mangButton.Enabled = false;
                    coordButton.Enabled = false;
                    this.Close();
                }
                else if (coordButton.Enabled == true)
                {
                    dashboardScreen openCoordinator = new dashboardScreen();
                    openCoordinator.Show();
                    mangButton.Enabled = false;
                    coordButton.Enabled = false;
                    this.Close();
                }
                else
                {
                    technicianDashboard technician = new technicianDashboard();
                    technician.Show();
                    this.Close();
                }
                 
            }
            //reset app
            else if (dialogResult == DialogResult.No)
            {

            }
            


        }
    }
}
