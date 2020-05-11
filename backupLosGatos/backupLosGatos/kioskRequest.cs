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
                ticketPage.Visible = true;
                viewKioskReToolStripMenuItem.Visible = true;
                pageDashboard.Show();
                this.Close();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginScreen newLogin = new loginScreen();
            newLogin.Show();
            this.Close();
        }

        private void createTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticketTest newTicket = new ticketTest();
            newTicket.ticketPage.Visible = false;

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

                newTicket.ticketIDTextBox.Text = (ds.Tables[0].Rows.Count + 100).ToString();
                //MessageBox.Show("Number of row(s) - " + ds.Tables[0].Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection to database! ");
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

        private void viewKioskReToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
