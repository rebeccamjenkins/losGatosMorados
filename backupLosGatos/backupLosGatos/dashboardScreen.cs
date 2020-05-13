using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace backupLosGatos
{
    public partial class dashboardScreen : Form
    {
        public dashboardScreen()
        {
            InitializeComponent();
        }

        public SqlConnection conn = null;
        SqlDataReader reader = null;

        private void dashboardScreen_Load(object sender, EventArgs e)
        {
            conn = new
            SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");

            conn.Open();
            SqlCommand getData = new SqlCommand("SELECT * FROM dbo.Tickets", conn);
            reader = getData.ExecuteReader();

            DataSet data = new DataSet();
            DataTable dtname2 = new DataTable("Table0");
            data.Tables.Add(dtname2);
            data.Load(reader, LoadOption.PreserveChanges, data.Tables[0]);
            this.ticketsBindingSource.DataSource = data.Tables[0];
            dashboardGrid.DataSource = data.Tables[0];

            //status dropdown
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

            //equipment dropdown
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

        private void dashboardGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //generates ticketDetails window populated with database information relevant to datagridview cell selected
            ticketDetails viewTicket = new ticketDetails();
            viewTicket.ticketIDText.Text = this.dashboardGrid.CurrentRow.Cells[0].Value.ToString();
            viewTicket.unitIDText.Text = this.dashboardGrid.CurrentRow.Cells[1].Value.ToString();
            viewTicket.equipmentCombo.SelectedValue = this.dashboardGrid.CurrentRow.Cells[2].Value.ToString();
            //viewTicket.dateSubmittedDateTimePicker.Text = this.dashboardGrid.CurrentRow.Cells[3].Value.ToString();
            viewTicket.priorityCombo.Text = this.dashboardGrid.CurrentRow.Cells[3].Value.ToString();
            viewTicket.statusCombo.Text = this.dashboardGrid.CurrentRow.Cells[2].Value.ToString();
            viewTicket.welderSignatureText.Text = this.dashboardGrid.CurrentRow.Cells[6].Value.ToString();
            viewTicket.inspectorSignatureText.Text = this.dashboardGrid.CurrentRow.Cells[7].Value.ToString();
            viewTicket.additionalInformationText.Text = this.dashboardGrid.CurrentRow.Cells[8].Value.ToString();

            if (labelRole.Text == "coordinator")
            {
                viewTicket.updateButton.Enabled = false;
                viewTicket.saveButton.Enabled = false;
                viewTicket.mangButton.Enabled = false;
            }

            viewTicket.Show();
            this.Hide();
        }

  
        private void refreshButton_Click(object sender, EventArgs e)
        {
            equipmentOption.Text = "";
            statusOption.Text = "";
            technicianOption.Text = "";
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
            viewKiosk.Show();
            conn.Close();
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

        private void ticketPage_Click(object sender, EventArgs e)
        {
            ticketDetails newTicket = new ticketDetails();
            if (labelRole.Text == "coordinator")
            {
                newTicket.updateButton.Enabled = false;
                newTicket.saveButton.Enabled = false;
                newTicket.coordButton.Enabled = false;

            }
            newTicket.coordButton.Enabled = true;
            newTicket.mangButton.Enabled = false;

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

            newTicket.Show();
            this.Close();
        }

        private void dashboardGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketDetails viewTicket = new ticketDetails();
            viewTicket.ticketIDText.Text = this.dashboardGrid.CurrentRow.Cells[0].Value.ToString();
            viewTicket.unitIDText.Text = this.dashboardGrid.CurrentRow.Cells[1].Value.ToString();
            //viewTicket.statusCombo.SelectedValue = this.dashboardGrid.CurrentRow.Cells[2].Value.ToString();
            //viewTicket.priorityCombo.SelectedValue = this.dashboardGrid.CurrentRow.Cells[3].Value.ToString();
            //viewTicket.dateText.Text = this.dashboardGrid.CurrentRow.Cells[4].Value.ToString();
            //viewTicket.equipmentCombo.SelectedValue = this.dashboardGrid.CurrentRow.Cells[5].Value.ToString();
            viewTicket.welderSignatureText.Text = this.dashboardGrid.CurrentRow.Cells[6].Value.ToString();
            viewTicket.inspectorSignatureText.Text = this.dashboardGrid.CurrentRow.Cells[7].Value.ToString();
            viewTicket.additionalInformationText.Text = this.dashboardGrid.CurrentRow.Cells[8].Value.ToString();

            viewTicket.statusText.Text = this.dashboardGrid.CurrentRow.Cells[2].Value.ToString();
            viewTicket.statusCombo.Visible = false;
            viewTicket.priorityText.Text = this.dashboardGrid.CurrentRow.Cells[3].Value.ToString();
            viewTicket.priorityCombo.Visible = false;
            viewTicket.equipText.Text = this.dashboardGrid.CurrentRow.Cells[5].Value.ToString();
            viewTicket.equipmentCombo.Visible = false;

            if (labelRole.Text == "coordinator")
            {
                viewTicket.updateButton.Enabled = false;
                viewTicket.saveButton.Enabled = false;
                viewTicket.mangButton.Enabled = false;
            }

            viewTicket.Show();
            this.Hide();
        }

        private void btnDashboardRefresh_Click(object sender, EventArgs e)
        {
            dashboardScreen newD = new dashboardScreen();
            newD.Show();
            this.Close();
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
    }
}
