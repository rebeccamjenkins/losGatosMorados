using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace backupLosGatos
{
    public partial class managerDashboard : Form
    {
        public managerDashboard()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        SqlDataReader reader = null;

        private void managerDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketsDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter1.Fill(this.ticketsDataSet.Tickets);
            conn = new
            SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");
            conn.Open();
            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tickets WHERE unitID = '" + unitManagerID.Text +"'", conn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dashboardGrid.DataSource = data;
            conn.Close();

            //status dropdown
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT status FROM dbo.Tickets", conn);
            reader = cmd.ExecuteReader();
            DataSet dsstatus = new DataSet();
            DataTable dtstatus = new DataTable("Table1");
            dsstatus.Tables.Add(dtstatus);
            dsstatus.Load(reader, LoadOption.PreserveChanges, dsstatus.Tables[0]);

            statusOption.ValueMember = "status";
            statusOption.DisplayMember = "status";
            statusOption.DataSource = dsstatus.Tables[0];
            statusOption.SelectedIndex = 0;
            statusOption.SelectedValue = 0;

            //assignee dropdown
            SqlCommand a_cmd = new SqlCommand("SELECT DISTINCT firstName FROM Users", conn);
            reader = a_cmd.ExecuteReader();
            DataSet dsname = new DataSet();
            DataTable dtname = new DataTable("Table 2");
            dsname.Tables.Add(dtname);
            dsname.Load(reader, LoadOption.PreserveChanges, dsname.Tables[0]);

            technicianOption.ValueMember = "firstName";
            technicianOption.DisplayMember = "firstName";
            technicianOption.DataSource = dsname.Tables[0];
            technicianOption.SelectedIndex = 0;
            technicianOption.SelectedValue = 0;

            //equipmentdropdown
            SqlCommand e_cmd = new SqlCommand("SELECT DISTINCT equipmentDescription FROM Equipment", conn);
            reader = e_cmd.ExecuteReader();
            DataSet dsequip = new DataSet();
            DataTable dtequip = new DataTable("Table 3");
            dsequip.Tables.Add(dtequip);
            dsequip.Load(reader, LoadOption.PreserveChanges, dsequip.Tables[0]);

            equipmentOption.ValueMember = "equipmentDescription";
            equipmentOption.DisplayMember = "equipmentDescription";
            equipmentOption.DataSource = dsequip.Tables[0];
            equipmentOption.SelectedIndex = 0;
            equipmentOption.SelectedValue = 0;
        }

        private void ticketPage_Click(object sender, EventArgs e)
        {

            ticketDetails newTicket = new ticketDetails();

            //makes sure the right permissions are given
            newTicket.mangButton.Enabled = true;
            newTicket.coordButton.Enabled = false;

            //disable the 'create ticket' button
            newTicket.ticketPage.Visible = false;
            newTicket.statusText.Visible = false;
            newTicket.equipText.Visible = false;
            newTicket.priorityText.Visible = false;
            newTicket.assignText.Visible = false;
            newTicket.dateText.Visible = false;
            newTicket.dateTimePicker.Visible = true;

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

            newTicket.Show();
            this.Hide();
        }

    

        private void refreshButton_Click(object sender, EventArgs e)
        {
            managerDashboard newDashboard = new managerDashboard();
            newDashboard.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            loginScreen newLogin = new loginScreen();
            newLogin.Show();
            this.Close();
        }

        private void viewKiosk_Click(object sender, EventArgs e)
        {
            
            kioskRequest viewKiosk = new kioskRequest();
            if (unitManagerID.Text == "manager")
            {
                viewKiosk.coordButton.Enabled = false;
            }
            viewKiosk.Show();
            this.Close();
        }

        private void queryTicket_TextChanged(object sender, EventArgs e)
        {
            conn = new
            SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");
            conn.Open();
            SqlDataAdapter c_id = new SqlDataAdapter("SELECT * FROM Tickets WHERE ticketID LIKE '" + queryTicket.Text + "%'", conn);
            DataTable dt = new DataTable();
            c_id.Fill(dt);
            dashboardGrid.DataSource = dt;
            conn.Close();
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            technicianOption.Text = null;
            statusOption.Text = null;
            equipmentOption.Text = null;

            conn = new
            SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tickets", conn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dashboardGrid.DataSource = data;
            conn.Close();
        }

        private void dashboardPage_Click(object sender, EventArgs e)
        {
            managerDashboard refresh = new managerDashboard();
            this.Close();
            refresh.Show();
        }

        private void dashboardGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketDetails viewTicket = new ticketDetails();
            //Ticket Number
            viewTicket.ticketIDText.Text = this.dashboardGrid.CurrentRow.Cells[0].Value.ToString();
            //Assigned To (COMBO)
            viewTicket.assignText.Text = this.dashboardGrid.CurrentRow.Cells[1].Value.ToString();
            viewTicket.associateIDComboBox.Visible = false;
            //Priority Level (COMBO)
            viewTicket.priorityText.Text = this.dashboardGrid.CurrentRow.Cells[2].Value.ToString();
            viewTicket.priorityCombo.Visible = false;
            //Status (COMBO)
            viewTicket.statusText.Text = this.dashboardGrid.CurrentRow.Cells[3].Value.ToString();
            viewTicket.statusCombo.Visible = false;
            //DateTime (COMBO)
            viewTicket.dateText.Text = this.dashboardGrid.CurrentRow.Cells[4].Value.ToString();
            viewTicket.dateTimePicker.Visible = false;
            //Equipment (COMBO)
            viewTicket.equipText.Text = this.dashboardGrid.CurrentRow.Cells[5].Value.ToString();
            viewTicket.equipmentCombo.Visible = false;
            //Welder Signature
            viewTicket.welderSignatureText.Text = this.dashboardGrid.CurrentRow.Cells[6].Value.ToString();
            viewTicket.welderSignatureText.ReadOnly = true;
            //Inspector Signature
            viewTicket.inspectorSignatureText.Text = this.dashboardGrid.CurrentRow.Cells[7].Value.ToString();
            viewTicket.inspectorSignatureText.ReadOnly = true;
            //Additional Information
            viewTicket.additionalInformationText.Text = this.dashboardGrid.CurrentRow.Cells[8].Value.ToString();
            viewTicket.additionalInformationText.ReadOnly = true;
            //Unit
            viewTicket.unitIDText.Text = this.dashboardGrid.CurrentRow.Cells[9].Value.ToString();
            viewTicket.unitIDText.ReadOnly = true;

                viewTicket.updateButton.Visible = true;
                viewTicket.saveButton.Visible = false;
                viewTicket.mangButton.Enabled = true;
                viewTicket.coordButton.Enabled = false; 

            viewTicket.Show();
            this.Hide();
        }

        private void equipmentOption_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string test;
            string test2;


            if (equipmentOption.SelectedValue == null)
            {

            }

            else
            {

                if (technicianOption.SelectedValue == null && statusOption.SelectedValue == null)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets WHERE equipmentID = @equipmentID", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@equipmentID";
                    param.Value = equipmentOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);

                    reader = cmd.ExecuteReader();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                    dashboardGrid.DataSource = ds.Tables[0];


                }
                else if (technicianOption.SelectedValue != null && statusOption.SelectedValue == null)
                {


                    SqlCommand cmd = new SqlCommand("SELECT username FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();

                    cmd.Parameters.Add(param);
                    test2 = (string)cmd.ExecuteScalar();


                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets WHERE userName = @username AND equipmentID = @equipmentID", conn);
                    SqlParameter id_param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();
                    id_param.ParameterName = "@username";
                    param2.ParameterName = "@equipmentID";
                    param2.Value = equipmentOption.SelectedValue.ToString();
                    id_param.Value = test2;
                    id_cmd.Parameters.Add(id_param);
                    id_cmd.Parameters.Add(param2);
                    reader = id_cmd.ExecuteReader();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                    dashboardGrid.DataSource = ds.Tables[0];


                }


                else if (technicianOption.SelectedValue == null && statusOption.SelectedValue != null)
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets WHERE status = @status and equipmentID = @equipmentID", conn);
                    SqlParameter param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();

                    param.ParameterName = "@status";
                    param2.ParameterName = "@equipmentID";

                    param.Value = statusOption.SelectedValue.ToString();
                    param2.Value = equipmentOption.SelectedValue.ToString();


                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param2);



                    reader = cmd.ExecuteReader();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                    dashboardGrid.DataSource = ds.Tables[0];


                }


                else if (technicianOption.SelectedValue != null && statusOption.SelectedValue != null)
                {

                    SqlCommand cmd = new SqlCommand("SELECT username FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();

                    cmd.Parameters.Add(param);
                    test2 = (string)cmd.ExecuteScalar();

                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets WHERE userName = @username AND equipmentID = @equipmentID AND status = @status", conn);
                    SqlParameter id_param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();
                    SqlParameter param3 = new SqlParameter();

                    id_param.ParameterName = "@username";
                    param2.ParameterName = "@equipmentID";
                    param3.ParameterName = "@status";


                    param2.Value = equipmentOption.SelectedValue.ToString();
                    id_param.Value = test2;
                    param3.Value = statusOption.SelectedValue.ToString();



                    id_cmd.Parameters.Add(id_param);
                    id_cmd.Parameters.Add(param2);
                    id_cmd.Parameters.Add(param3);
                    reader = id_cmd.ExecuteReader();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                    dashboardGrid.DataSource = ds.Tables[0];


                }
            }
        }

        private void statusOption_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string test;
            string test2;

            if (statusOption.SelectedValue == null)
            {
            }

            else
            {



                if (technicianOption.SelectedValue == null && equipmentOption.SelectedValue == null)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets WHERE status = @status", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@status";
                    param.Value = statusOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);

                    reader = cmd.ExecuteReader();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                    dashboardGrid.DataSource = ds.Tables[0];
                }

                else if (technicianOption.SelectedValue != null && equipmentOption.SelectedValue == null)
                {

                    SqlCommand cmd = new SqlCommand("SELECT username FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();

                    cmd.Parameters.Add(param);
                    test2 = (string)cmd.ExecuteScalar();


                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets WHERE userName = @username AND status = @status", conn);
                    SqlParameter id_param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();
                    id_param.ParameterName = "@username";
                    param2.ParameterName = "@status";
                    param2.Value = statusOption.SelectedValue.ToString();
                    id_param.Value = test2;
                    id_cmd.Parameters.Add(id_param);
                    id_cmd.Parameters.Add(param2);
                    reader = id_cmd.ExecuteReader();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                    dashboardGrid.DataSource = ds.Tables[0];

                }

                else if (technicianOption.SelectedValue == null && equipmentOption.SelectedValue != null)
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets WHERE status = @status and equipmentID = @equipmentID", conn);
                    SqlParameter param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();

                    param.ParameterName = "@status";
                    param2.ParameterName = "@equipmentID";

                    param.Value = statusOption.SelectedValue.ToString();
                    param2.Value = equipmentOption.SelectedValue.ToString();


                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param2);



                    reader = cmd.ExecuteReader();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                    dashboardGrid.DataSource = ds.Tables[0];

                }

                else if (technicianOption.SelectedValue != null && equipmentOption.SelectedValue != null)
                {

                    SqlCommand cmd = new SqlCommand("SELECT username FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();

                    cmd.Parameters.Add(param);
                    test2 = (string)cmd.ExecuteScalar();

                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets WHERE userName = @username AND equipmentID = @equipmentID AND status = @status", conn);
                    SqlParameter id_param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();
                    SqlParameter param3 = new SqlParameter();

                    id_param.ParameterName = "@username";
                    param2.ParameterName = "@equipmentID";
                    param3.ParameterName = "@status";


                    param2.Value = equipmentOption.SelectedValue.ToString();
                    id_param.Value = test2;
                    param3.Value = statusOption.SelectedValue.ToString();



                    id_cmd.Parameters.Add(id_param);
                    id_cmd.Parameters.Add(param2);
                    id_cmd.Parameters.Add(param3);
                    reader = id_cmd.ExecuteReader();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                    dashboardGrid.DataSource = ds.Tables[0];


                }
            }



        }

        private void technicianOption_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string test;
            string test2;

            if (technicianOption.SelectedValue == null)
            {
            }
            else
            {
                if (statusOption.SelectedValue == null && equipmentOption.SelectedValue == null)
                {

                    SqlCommand cmd = new SqlCommand("SELECT username FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();

                    cmd.Parameters.Add(param);
                    test2 = (string)cmd.ExecuteScalar();



                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets WHERE userName = @username", conn);
                    SqlParameter id_param = new SqlParameter();
                    id_param.ParameterName = "@username";
                    id_param.Value = test2;
                    id_cmd.Parameters.Add(id_param);
                    reader = id_cmd.ExecuteReader();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                    dashboardGrid.DataSource = ds.Tables[0];


                }

                else if (statusOption.SelectedValue != null && equipmentOption.SelectedValue == null)
                {

                    SqlCommand cmd = new SqlCommand("SELECT username FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();

                    cmd.Parameters.Add(param);
                    test2 = (string)cmd.ExecuteScalar();


                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets WHERE userName = @username AND status = @status", conn);
                    SqlParameter id_param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();
                    id_param.ParameterName = "@username";
                    param2.ParameterName = "@status";
                    param2.Value = statusOption.SelectedValue.ToString();
                    id_param.Value = test2;
                    id_cmd.Parameters.Add(id_param);
                    id_cmd.Parameters.Add(param2);
                    reader = id_cmd.ExecuteReader();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                    dashboardGrid.DataSource = ds.Tables[0];

                }
                else if (statusOption.SelectedValue == null && equipmentOption.SelectedValue != null)
                {

                    SqlCommand cmd = new SqlCommand("SELECT username FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();

                    cmd.Parameters.Add(param);
                    test2 = (string)cmd.ExecuteScalar();


                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets WHERE userName = @username AND equipmentID = @equipmentID", conn);
                    SqlParameter id_param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();
                    id_param.ParameterName = "@username";
                    param2.ParameterName = "@equipmentID";
                    param2.Value = equipmentOption.SelectedValue.ToString();
                    id_param.Value = test2;
                    id_cmd.Parameters.Add(id_param);
                    id_cmd.Parameters.Add(param2);
                    reader = id_cmd.ExecuteReader();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                    dashboardGrid.DataSource = ds.Tables[0];

                }
                else if (statusOption.SelectedValue != null && equipmentOption.SelectedValue != null)
                {

                    SqlCommand cmd = new SqlCommand("SELECT username FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();

                    cmd.Parameters.Add(param);
                    test2 = (string)cmd.ExecuteScalar();

                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets WHERE userName = @username AND equipmentID = @equipmentID AND status = @status", conn);
                    SqlParameter id_param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();
                    SqlParameter param3 = new SqlParameter();

                    id_param.ParameterName = "@username";
                    param2.ParameterName = "@equipmentID";
                    param3.ParameterName = "@status";


                    param2.Value = equipmentOption.SelectedValue.ToString();
                    id_param.Value = test2;
                    param3.Value = statusOption.SelectedValue.ToString();



                    id_cmd.Parameters.Add(id_param);
                    id_cmd.Parameters.Add(param2);
                    id_cmd.Parameters.Add(param3);
                    reader = id_cmd.ExecuteReader();

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

                    dashboardGrid.DataSource = ds.Tables[0];

                }




            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            queryTicket.Text = "";
        }
    }
}

