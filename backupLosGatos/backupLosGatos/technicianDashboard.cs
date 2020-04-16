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
    public partial class technicianDashboard : Form
    {
        public technicianDashboard()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        SqlDataReader reader = null;

        private void technicianDashboard_Load(object sender, EventArgs e)
        {

            //this.usersTableAdapter.Fill(this.gROUP6DataSet.Users);
            //this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);


            // Start out by connecting to the data source: You will need your connection string here
            conn = new

            SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");

            conn.Open();

            // 1. declare a SQL Command. Select a Unique Set of Cities from the Guest Table. 
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT firstName FROM Users", conn);

            // 2. get a data stream set up
            reader = cmd.ExecuteReader();

            // 3. Get a Data Set called City
            DataSet dsname = new DataSet();

            // 4. Create Data Table from the Data Set to hold query results
            DataTable dtname = new DataTable("Table1");
            dsname.Tables.Add(dtname);

            // 5. Load up the Query result
            dsname.Load(reader, LoadOption.PreserveChanges, dsname.Tables[0]);

            // 6. Put the retrieved values into the ComboBox
            technicianOption.ValueMember = "firstName";
            technicianOption.DisplayMember = "firstName";
            technicianOption.DataSource = dsname.Tables[0];
            technicianOption.SelectedIndex = 0;
            technicianOption.SelectedValue = 0;



        }

        private void ticketPage_Click(object sender, EventArgs e)
        {
            ticketDetails newTicket = new ticketDetails();
            newTicket.Show();
            this.Hide();
        }

        private void statusOption_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void TicketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gROUP6DataSet);

        }

        private void TechnicianOption_SelectedIndexChanged(object sender, EventArgs e)
        {

            Int32 test = 0;


            // 7. First time this runs, it will be null so do not send a parameter query
            if (technicianOption.SelectedValue == null)
            {
            }
            else
            {


                // 9. declare command object with parameter
                SqlCommand cmd = new SqlCommand("SELECT associateID FROM Users WHERE firstName = @firstName", conn);

                // 10. define parameters used in command object
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@firstName";

                // 11. Get value to populate parameter from combo box selection
                param.Value = technicianOption.SelectedValue.ToString();

                // 12. add new parameter to command object
                cmd.Parameters.Add(param);

                test = (Int32)cmd.ExecuteScalar();
                //13. Execute the command
                //reader = cmd.ExecuteReader();

                /*
                // 14. Get the new data set and load it as a table
                DataSet ds = new DataSet();
                DataTable dt = new DataTable("Table1");
                ds.Tables.Add(dt);
                ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                // 15. Stick the new table into the DataGridView

                assignmentsDataGridView.DataSource = ds.Tables[0];
                */

                //label1.Text = test.ToString();


                // SECOND QUERY


                // 9. declare command object with parameter
                //Tickets.ticketID
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Tickets, Assignments WHERE Assignments.associateID = @associateID AND Assignments.ticketID = Tickets.ticketID", conn);

                // 10. define parameters used in command object
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@associateID";

                // 11. Get value to populate parameter from combo box selection
                param1.Value = test.ToString();


                // 12. add new parameter to command object
                cmd1.Parameters.Add(param1);

                // 13. Execute the command
                reader = cmd1.ExecuteReader();

                // 14. Get the new data set and load it as a table
                DataSet ds2 = new DataSet();
                DataTable dt2 = new DataTable("Table2");
                ds2.Tables.Add(dt2);
                ds2.Load(reader, LoadOption.PreserveChanges, ds2.Tables[0]);


                // 15. Stick the new table into the DataGridView

                this.ticketsBindingSource.DataSource = ds2.Tables[0];

                dashboardGrid.DataSource = ds2.Tables[0];


            }


        }
    }
}
