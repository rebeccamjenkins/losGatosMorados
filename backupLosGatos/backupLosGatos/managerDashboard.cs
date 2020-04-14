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
    public partial class managerDashboard : Form
    {
        public managerDashboard()
        {
            InitializeComponent();
        }

        // Added Sql connection and reader objects for later use 
        SqlConnection conn = null;
        SqlDataReader reader = null;

        private void managerDashboard_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.gROUP6DataSet.Users);
            this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);

            //Below here is all added code from Lab 7 concerning screen load

            // Start out by connecting to the data source: You will need your connection string here
            conn = new
            SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");

            conn.Open();

            // 1. declare a SQL Command. Select a Unique Set of Statuses from the Tickets Table. 
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT status FROM dbo.Tickets", conn);

            // 2. get a data stream set up
            reader = cmd.ExecuteReader();

            // 3. Get a Data Set called Status
            DataSet dsstatus = new DataSet();

            // 4. Create Data Table from the Data Set to hold query results
            DataTable dtstatus = new DataTable("Table1");
            dsstatus.Tables.Add(dtstatus);

            // 5. Load up the Query result
            dsstatus.Load(reader, LoadOption.PreserveChanges, dsstatus.Tables[0]);

            // 6. Put the retrieved values into the ComboBox
            statusComboBox.ValueMember = "status";
            statusComboBox.DisplayMember = "status";
            statusComboBox.DataSource = dsstatus.Tables[0];
            statusComboBox.SelectedIndex = 0;
            statusComboBox.SelectedValue = 0;

            // TODO: This line of code loads data into the ????'auntiesDB_SS1DataSet.Guest'???? table. You can move, or remove it, as needed.
            //this.guestTableAdapter.Fill(this.auntiesDB_SS1DataSet.Guest);
            // TODO: This line of code loads data into the 'auntiesDB_SSDataSet.Guests' table. You can move, or remove it, as needed.
            //this.guestsTableAdapter.Fill(this.auntiesDB_SSDataSet.Guests);

            // Lab 7 screen load code ends here
        }

        private void ticketPage_Click(object sender, EventArgs e)
        {
            ticketDetails newTicket = new ticketDetails();
            newTicket.Show();
            this.Close();
        }

        private void dashboardGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketDetails viewTicket = new ticketDetails();
            viewTicket.ticketIDTextBox.Text = this.managerDashboardGrid.CurrentRow.Cells[0].Value.ToString();
            viewTicket.unitIDTextBox.Text = this.managerDashboardGrid.CurrentRow.Cells[1].Value.ToString();
            viewTicket.equipmentIDTextBox.Text = this.managerDashboardGrid.CurrentRow.Cells[2].Value.ToString();
            viewTicket.dateSubmittedDateTimePicker.Text = this.managerDashboardGrid.CurrentRow.Cells[3].Value.ToString();
            viewTicket.priorityComboBox.Text = this.managerDashboardGrid.CurrentRow.Cells[4].Value.ToString();
            viewTicket.statusComboBox.Text = this.managerDashboardGrid.CurrentRow.Cells[5].Value.ToString();
            viewTicket.welderSignatureTextBox.Text = this.managerDashboardGrid.CurrentRow.Cells[6].Value.ToString();
            viewTicket.inspectorSignatureTextBox.Text = this.managerDashboardGrid.CurrentRow.Cells[7].Value.ToString();
            viewTicket.additionalInformationTextBox.Text = this.managerDashboardGrid.CurrentRow.Cells[8].Value.ToString();

            viewTicket.Show();
            this.Close();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // start code from lab 7 regarding drop down

            // 7. First time this runs, it will be null so do not send a parameter query
            if (statusComboBox.SelectedValue == null)
            {
            }

            else
            {
                // 9. declare command object with parameter
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets WHERE status = @status", conn);

                // 10. define parameters used in command object
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@status";

                // 11. Get value to populate parameter from combo box selection
                param.Value = statusComboBox.SelectedValue.ToString();

                // 12. add new parameter to command object
                cmd.Parameters.Add(param);

                // 13. Execute the command
                reader = cmd.ExecuteReader();

                // 14. Get the new data set and load it as a table
                DataSet ds = new DataSet();
                DataTable dt = new DataTable("Table1");
                ds.Tables.Add(dt);
                ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                // 15. Stick the new table into the DataGridView

                managerDashboardGrid.DataSource = ds.Tables[0];

                // end of lab 7 code regarding drop down
            }
        }
    }
}
