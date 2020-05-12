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
            // TODO: This line of code loads data into the 'gROUP6DataSet.Kiosk' table. You can move, or remove it, as needed.
            this.kioskTableAdapter.Fill(this.gROUP6DataSet.Kiosk);

        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            loginScreen login = new loginScreen();

            login.Show();
            this.Close();
        }

        private void dashboardGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
           

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to approve ticket?", "Ticket Approval", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");
                DateTime dateValue;
                int numID = 0;

                SqlCommand cmd = new SqlCommand("sp_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dateSubmitted", this.dashboardGrid.CurrentRow.Cells[4].Value.ToString());
                cmd.Parameters.AddWithValue("@unitID", this.dashboardGrid.CurrentRow.Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@equipmentID", this.dashboardGrid.CurrentRow.Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@priorityLevel", this.dashboardGrid.CurrentRow.Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@technicianName", this.dashboardGrid.CurrentRow.Cells[6].Value.ToString());
                cmd.Parameters.AddWithValue("@additionalInformation", this.dashboardGrid.CurrentRow.Cells[7].Value.ToString());

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i != 0)
                {
                    MessageBox.Show("Ticket Approved and added to Database.");

                }
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }



        }
    }
}
