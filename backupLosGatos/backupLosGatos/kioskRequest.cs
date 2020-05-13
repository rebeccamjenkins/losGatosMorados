using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace backupLosGatos
{
    public partial class kioskRequest : Form
    {
        public kioskRequest()
        {
            InitializeComponent();
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
        }

        private void logout_Click(object sender, EventArgs e)
        {
            loginScreen newLogin = new loginScreen();
            newLogin.Show();
            this.Close();
        }

        private void createTicket_Click(object sender, EventArgs e)
        {
            ticketDetails newTicket = new ticketDetails();
            newTicket.Show();
            this.Hide();

            //this makes it so it autofills the ticket number for us
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;

            connetionString = "Data Source=10.135.85.184;Initial Catalog=Group6;User ID=Group6;Password=Grp6s2117";
            sql = "SELECT ticketID FROM Tickets";
            connection = new SqlConnection(connetionString);

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
                MessageBox.Show("Cannot open connection to database! ");
            }
            if (coordButton.Enabled == true)
            {
                newTicket.mangButton.Enabled = false;
                newTicket.coordButton.Enabled = true;
                newTicket.Show();
                this.Hide();
            }
            else if (mangButton.Enabled == true)
            {
                newTicket.mangButton.Enabled = true;
                newTicket.coordButton.Enabled = false;
                newTicket.Show();
                this.Hide();
            }
        }

        private void viewKiosk_Click(object sender, EventArgs e)
        {

        }

        private void kioskRequest_Load(object sender, EventArgs e)
        {
            this.kioskTableAdapter.Fill(this.gROUP6DataSet.Kiosk);
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            loginScreen login = new loginScreen();

            login.Show();
            this.Close();
        }
        private void dashboardGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*generates ticketDetails window populated with database information relevant to datagridview cell selected
            ticketDetails viewTicket = new ticketDetails();
            viewTicket.ticketIDText.Text = this.dashboardGrid.CurrentRow.Cells[0].Value.ToString();
            viewTicket.unitIDText.Text = this.dashboardGrid.CurrentRow.Cells[1].Value.ToString();
            viewTicket.equipmentCombo.SelectedValue = this.dashboardGrid.CurrentRow.Cells[2].Value.ToString();
            viewTicket.dateSubmittedDateTimePicker.Text = this.dashboardGrid.CurrentRow.Cells[4].Value.ToString();
            viewTicket.priorityCombo.Text = this.dashboardGrid.CurrentRow.Cells[3].Value.ToString();
            viewTicket.statusCombo.Text = this.dashboardGrid.CurrentRow.Cells[5].Value.ToString();
            viewTicket.welderSignatureText.Text = this.dashboardGrid.CurrentRow.Cells[6].Value.ToString();*/

            //create data source and static variables
            string connectionString = @"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true";
            SqlConnection con = new SqlConnection(connectionString);
            int numID = 0;

            //pull number of rows from database in order to create ticketID
            con.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM Tickets", con);
            Int32 count = (Int32)comm.ExecuteScalar();
            con.Close();

            //create strings for all variables
            numID = count + 1;

            /*
            using (SqlConnection openCon = new SqlConnection(connectionString))
            {
                string injection = "INSERT into Kiosk (ticketID, unitID, equipmentID, priorityLevel, technicianName, additionalInfo, dateSubmitted) VALUES (@ticketID,@unitID,@equipmentID,@priorityLevel, @technicianName, @additionalInfo, @dateSubmitted)";
                using (SqlCommand command = new SqlCommand(injection))
                {
                    command.Connection = openCon;
                    command.Parameters.Add("@ticketID", SqlDbType.NVarChar, 50).Value = numID;
                    command.Parameters.Add("@unitID", SqlDbType.NChar, 10).Value = unitID;
                    command.Parameters.Add("@equipmentID", SqlDbType.NChar, 10).Value = equipmentID;
                    command.Parameters.Add("@priorityLevel", SqlDbType.NChar, 10).Value = priorityLevel;
                    command.Parameters.Add("@technicianName", SqlDbType.NVarChar, 50).Value = technicianName;
                    command.Parameters.Add("@additionalInfo", SqlDbType.NVarChar, 1000).Value = additionalInfo;
                    command.Parameters.Add("@dateSubmitted", SqlDbType.DateTime, 30).Value = date;
                    openCon.Open();
                    command.ExecuteNonQuery();
                }
            }*/

            DialogResult dialogResult = MessageBox.Show("Do you want to approve this ticket?", "Ticket Approval", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection openCon = new SqlConnection(connectionString))
                {
                    DateTime dateValue;
                    string injection = "INSERT into Tickets (ticketID, unitID, equipmentID, priorityLevel, dateSubmitted, additionalInformation, employeeName) VALUES (@ticketID,@unitID,@equipmentID,@priorityLevel, @dateSubmitted, @additionalInformation, @technicianName)";


                    using (SqlCommand cmd = new SqlCommand(injection))
                    {
                        cmd.Connection = openCon;

                        cmd.Parameters.AddWithValue("@ticketID", numID);
                        cmd.Parameters.AddWithValue("@unitID", this.dashboardGrid.CurrentRow.Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@equipmentID", this.dashboardGrid.CurrentRow.Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@priorityLevel", this.dashboardGrid.CurrentRow.Cells[3].Value.ToString());
                        cmd.Parameters.AddWithValue("@dateSubmitted", this.dashboardGrid.CurrentRow.Cells[4].Value.ToString());
                        cmd.Parameters.AddWithValue("@additionalInformation", this.dashboardGrid.CurrentRow.Cells[6].Value.ToString());
                        cmd.Parameters.AddWithValue("@technicianName", this.dashboardGrid.CurrentRow.Cells[5].Value.ToString());

                        openCon.Open();
                        int i = cmd.ExecuteNonQuery();

                        if (i != 0)
                        {
                            MessageBox.Show("Ticket Approved and added to Database.");
                        }
                    }
                }
                int value;
                string str = this.dashboardGrid.CurrentRow.Cells[0].Value.ToString();

                value = Int32.Parse(str);
                int place = 107 - value;

                try
                {
                    using (SqlConnection con2 = new SqlConnection("Data Source = 10.135.85.184; Initial Catalog = Group6; User ID = Group6; Password = Grp6s2117"))
                    {
                        using (SqlCommand commandDel = new SqlCommand("DELETE FROM Kiosk WHERE ticketID = " + value))
                        {
                            commandDel.Connection = con2;
                            con2.Open();
                            commandDel.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Weld Request Denied.");
                    kioskRequest refresh = new kioskRequest();
                    this.Close();
                    refresh.Show();

                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                DialogResult dialogResult2 = MessageBox.Show("Are you sure? Ticket request will be deleted.", "Deny Ticket?", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    int value;
                    string str = this.dashboardGrid.CurrentRow.Cells[0].Value.ToString();

                    value = Int32.Parse(str);
                    int place = 107 - value;

                    try
                    {
                        using (SqlConnection con2 = new SqlConnection("Data Source = 10.135.85.184; Initial Catalog = Group6; User ID = Group6; Password = Grp6s2117"))
                        {

                            using (SqlCommand commandDel = new SqlCommand("DELETE FROM Kiosk WHERE ticketID = " + value))
                            {
                                commandDel.Connection = con2;
                                con2.Open();
                                commandDel.ExecuteNonQuery();
                            }

                        }

                        MessageBox.Show("Weld Request Denied.");
                        kioskRequest refresh = new kioskRequest();
                        this.Close();
                        refresh.Show();

                    }
                    catch (SystemException ex)
                    {
                        MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                    }
                }
                else
                {

                }
            }
        }
    }
}
