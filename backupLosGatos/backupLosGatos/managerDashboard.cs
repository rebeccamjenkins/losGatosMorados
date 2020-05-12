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
            conn = new
            SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");

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
                MessageBox.Show("Cannot open connection to database!");
            }

            newTicket.Show();
            this.Hide();
        }

        private void dashboardGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //generates ticketDetails window populated with database information relevant to datagridview cell selected
            ticketDetails viewTicket = new ticketDetails();
            viewTicket.ticketIDText.Text = this.dashboardGrid.CurrentRow.Cells[0].Value.ToString();
            viewTicket.unitIDText.Text = this.dashboardGrid.CurrentRow.Cells[1].Value.ToString();
            viewTicket.equipmentCombo.SelectedValue = this.dashboardGrid.CurrentRow.Cells[2].Value.ToString();
            viewTicket.dateText.Text = this.dashboardGrid.CurrentRow.Cells[3].Value.ToString();
            viewTicket.priorityCombo.Text = this.dashboardGrid.CurrentRow.Cells[4].Value.ToString();
            viewTicket.statusCombo.Text = this.dashboardGrid.CurrentRow.Cells[5].Value.ToString();
            viewTicket.welderSignatureText.Text = this.dashboardGrid.CurrentRow.Cells[6].Value.ToString();
            viewTicket.inspectorSignatureText.Text = this.dashboardGrid.CurrentRow.Cells[7].Value.ToString();
            viewTicket.additionalInformationText.Text = this.dashboardGrid.CurrentRow.Cells[8].Value.ToString();

            if (labelRole.Text == "manager")
            {
                //viewTicket.updateButton.Enabled = false;
                //viewTicket.saveButton.Enabled = false;
                viewTicket.coordButton.Enabled = false;
            }

            viewTicket.Show();
            this.Hide();
        }

        private void equipmentOption_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Int32 test = 0;
            Int32 test1 = 0;
            Int32 test2 = 0;

            if (equipmentOption.SelectedValue == null)
            {
            }
            else
            {
                if (technicianOption.SelectedValue == null && statusOption.SelectedValue == null)
                {
                    SqlCommand cmd = new SqlCommand("SELECT equipmentID FROM Equipment WHERE equipmentDescription = @equipmentDescription", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@equipmentDescription";
                    param.Value = equipmentOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);
                    test = (Int32)cmd.ExecuteScalar();

                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets, Equipment WHERE Equipment.equipmentID = @equipmentID and Tickets.equipmentID = @equipmentID", conn);
                    SqlParameter id_param = new SqlParameter();
                    id_param.ParameterName = "@equipmentID";
                    id_param.Value = test.ToString();
                    id_cmd.Parameters.Add(id_param);
                    reader = id_cmd.ExecuteReader();

                    DataSet dsname2 = new DataSet();
                    DataTable dtname2 = new DataTable("Table4");
                    dsname2.Tables.Add(dtname2);
                    dsname2.Load(reader, LoadOption.PreserveChanges, dsname2.Tables[0]);
                    this.ticketsBindingSource.DataSource = dsname2.Tables[0];
                    dashboardGrid.DataSource = dsname2.Tables[0];
                }
                else if (technicianOption.SelectedValue != null && statusOption.SelectedValue == null)
                {
                    SqlCommand cmd = new SqlCommand("SELECT associateID FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);
                    test = (Int32)cmd.ExecuteScalar();

                    SqlCommand cmd1 = new SqlCommand("SELECT equipmentID FROM Equipment WHERE equipmentDescription = @equipmentDescription", conn);
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@equipmentDescription";
                    param1.Value = equipmentOption.SelectedValue.ToString();
                    cmd1.Parameters.Add(param1);
                    test1 = (Int32)cmd1.ExecuteScalar();


                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets, Assignments, Equipment WHERE Assignments.associateID = @associateID AND Assignments.ticketID = Tickets.ticketID AND Equipment.equipmentID = @equipmentID and Tickets.equipmentID = @equipmentID", conn);
                    SqlParameter id_param = new SqlParameter();
                    SqlParameter id_param1 = new SqlParameter();
                    id_param.ParameterName = "@associateID";
                    id_param.Value = test.ToString();

                    id_param1.ParameterName = "@equipmentID";
                    id_param1.Value = test1.ToString();

                    id_cmd.Parameters.Add(id_param);
                    id_cmd.Parameters.Add(id_param1);
                    reader = id_cmd.ExecuteReader();


                    DataSet dsname3 = new DataSet();
                    DataTable dtname3 = new DataTable("Table5");
                    dsname3.Tables.Add(dtname3);
                    dsname3.Load(reader, LoadOption.PreserveChanges, dsname3.Tables[0]);
                    this.ticketsBindingSource.DataSource = dsname3.Tables[0];
                    dashboardGrid.DataSource = dsname3.Tables[0];
                }
                else if (technicianOption.SelectedValue == null && statusOption.SelectedValue != null)
                {
                    string selection1 = statusOption.SelectedValue.ToString();

                    SqlCommand cmd = new SqlCommand("SELECT equipmentID FROM Equipment WHERE equipmentDescription = @equipmentDescription", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@equipmentDescription";
                    param.Value = equipmentOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);
                    test = (Int32)cmd.ExecuteScalar();

                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets, Equipment WHERE Equipment.equipmentID = @equipmentID AND Tickets.equipmentID = @equipmentID AND Tickets.status = " + "'" + selection1 + "'", conn);
                    SqlParameter id_param = new SqlParameter();
                    id_param.ParameterName = "@equipmentID";
                    id_param.Value = test.ToString();
                    id_cmd.Parameters.Add(id_param);
                    reader = id_cmd.ExecuteReader();

                    DataSet dsname2 = new DataSet();
                    DataTable dtname2 = new DataTable("Table3");
                    dsname2.Tables.Add(dtname2);
                    dsname2.Load(reader, LoadOption.PreserveChanges, dsname2.Tables[0]);
                    this.ticketsBindingSource.DataSource = dsname2.Tables[0];
                    dashboardGrid.DataSource = dsname2.Tables[0];
                }
                else if (technicianOption.SelectedValue != null && statusOption.SelectedValue != null)
                {
                    string selection1 = statusOption.SelectedValue.ToString();

                    SqlCommand cmd = new SqlCommand("SELECT associateID FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);
                    test = (Int32)cmd.ExecuteScalar();

                    SqlCommand cmd1 = new SqlCommand("SELECT equipmentID FROM Equipment WHERE equipmentDescription = @equipmentDescription", conn);
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@equipmentDescription";
                    param1.Value = equipmentOption.SelectedValue.ToString();
                    cmd1.Parameters.Add(param1);
                    test1 = (Int32)cmd1.ExecuteScalar();

                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets, Assignments, Equipment WHERE Assignments.associateID = @associateID AND Assignments.ticketID = Tickets.ticketID AND Equipment.equipmentID = @equipmentID and Tickets.equipmentID = @equipmentID  AND Tickets.status = " + "'" + selection1 + "'", conn);
                    SqlParameter id_param = new SqlParameter();
                    SqlParameter id_param1 = new SqlParameter();
                    id_param.ParameterName = "@associateID";
                    id_param.Value = test.ToString();

                    id_param1.ParameterName = "@equipmentID";
                    id_param1.Value = test1.ToString();

                    id_cmd.Parameters.Add(id_param);
                    id_cmd.Parameters.Add(id_param1);
                    reader = id_cmd.ExecuteReader();

                    DataSet dsname3 = new DataSet();
                    DataTable dtname3 = new DataTable("Table5");
                    dsname3.Tables.Add(dtname3);
                    dsname3.Load(reader, LoadOption.PreserveChanges, dsname3.Tables[0]);
                    this.ticketsBindingSource.DataSource = dsname3.Tables[0];
                    dashboardGrid.DataSource = dsname3.Tables[0];
                }
            }
        }

        private void statusOption_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Int32 test = 0;
            Int32 test1 = 0;
            if (statusOption.SelectedValue == null)
            {
            }
            else
            {
                string selection1 = statusOption.SelectedValue.ToString();

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
                    SqlCommand cmd = new SqlCommand("SELECT associateID FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);
                    test = (Int32)cmd.ExecuteScalar();

                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets, Assignments WHERE Assignments.associateID = @associateID AND Assignments.ticketID = Tickets.ticketID AND Tickets.status = " + "'" + selection1 + "'", conn);
                    SqlParameter id_param = new SqlParameter();
                    id_param.ParameterName = "@associateID";
                    id_param.Value = test.ToString();
                    id_cmd.Parameters.Add(id_param);
                    reader = id_cmd.ExecuteReader();

                    DataSet dsname2 = new DataSet();
                    DataTable dtname2 = new DataTable("Table3");
                    dsname2.Tables.Add(dtname2);
                    dsname2.Load(reader, LoadOption.PreserveChanges, dsname2.Tables[0]);
                    this.ticketsBindingSource.DataSource = dsname2.Tables[0];
                    dashboardGrid.DataSource = dsname2.Tables[0];
                }
                else if (technicianOption.SelectedValue == null && equipmentOption.SelectedValue != null)
                {
                    SqlCommand cmd = new SqlCommand("SELECT equipmentID FROM Equipment WHERE equipmentDescription = @equipmentDescription", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@equipmentDescription";
                    param.Value = equipmentOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);
                    test = (Int32)cmd.ExecuteScalar();

                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets, Equipment WHERE Equipment.equipmentID = @equipmentID AND Tickets.equipmentID = @equipmentID AND Tickets.status = " + "'" + selection1 + "'", conn);
                    SqlParameter id_param = new SqlParameter();
                    id_param.ParameterName = "@equipmentID";
                    id_param.Value = test.ToString();
                    id_cmd.Parameters.Add(id_param);
                    reader = id_cmd.ExecuteReader();

                    DataSet dsname2 = new DataSet();
                    DataTable dtname2 = new DataTable("Table3");
                    dsname2.Tables.Add(dtname2);
                    dsname2.Load(reader, LoadOption.PreserveChanges, dsname2.Tables[0]);
                    this.ticketsBindingSource.DataSource = dsname2.Tables[0];
                    dashboardGrid.DataSource = dsname2.Tables[0];
                }
                else if (technicianOption.SelectedValue != null && equipmentOption.SelectedValue != null)
                {
                    SqlCommand cmd = new SqlCommand("SELECT associateID FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);
                    test = (Int32)cmd.ExecuteScalar();

                    SqlCommand cmd1 = new SqlCommand("SELECT equipmentID FROM Equipment WHERE equipmentDescription = @equipmentDescription", conn);
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@equipmentDescription";
                    param1.Value = equipmentOption.SelectedValue.ToString();
                    cmd1.Parameters.Add(param1);
                    test1 = (Int32)cmd1.ExecuteScalar();


                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets, Assignments, Equipment WHERE Assignments.associateID = @associateID AND Assignments.ticketID = Tickets.ticketID AND Equipment.equipmentID = @equipmentID AND Tickets.equipmentID = @equipmentID AND Tickets.status = " + "'" + selection1 + "'", conn);
                    SqlParameter id_param = new SqlParameter();
                    SqlParameter id_param1 = new SqlParameter();
                    id_param.ParameterName = "@associateID";
                    id_param.Value = test.ToString();
                    id_param1.ParameterName = "@equipmentID";
                    id_param1.Value = test1.ToString();

                    id_cmd.Parameters.Add(id_param);
                    id_cmd.Parameters.Add(id_param1);
                    reader = id_cmd.ExecuteReader();

                    DataSet dsname2 = new DataSet();
                    DataTable dtname2 = new DataTable("Table3");
                    dsname2.Tables.Add(dtname2);
                    dsname2.Load(reader, LoadOption.PreserveChanges, dsname2.Tables[0]);
                    this.ticketsBindingSource.DataSource = dsname2.Tables[0];
                    dashboardGrid.DataSource = dsname2.Tables[0];
                }
            }
        }
        private void technicianOption_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Int32 test = 0;
            Int32 test1 = 0;
            Int32 test3 = 0;

            if (technicianOption.SelectedValue == null)
            {
            }
            else
            {
                if (statusOption.SelectedValue == null && equipmentOption.SelectedValue == null)
                {
                    SqlCommand cmd = new SqlCommand("SELECT associateID FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);
                    test = (Int32)cmd.ExecuteScalar();

                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets, Assignments WHERE Assignments.associateID = @associateID AND Assignments.ticketID = Tickets.ticketID", conn);
                    SqlParameter id_param = new SqlParameter();
                    id_param.ParameterName = "@associateID";
                    id_param.Value = test.ToString();
                    id_cmd.Parameters.Add(id_param);
                    reader = id_cmd.ExecuteReader();

                    DataSet dsname2 = new DataSet();
                    DataTable dtname2 = new DataTable("Table3");
                    dsname2.Tables.Add(dtname2);
                    dsname2.Load(reader, LoadOption.PreserveChanges, dsname2.Tables[0]);
                    this.ticketsBindingSource.DataSource = dsname2.Tables[0];
                    dashboardGrid.DataSource = dsname2.Tables[0];
                }
                else if (statusOption.SelectedValue != null && equipmentOption.SelectedValue == null)
                {
                    string selection1 = statusOption.SelectedValue.ToString();

                    SqlCommand cmd = new SqlCommand("SELECT associateID FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);
                    test = (Int32)cmd.ExecuteScalar();

                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets, Assignments WHERE Assignments.associateID = @associateID AND Assignments.ticketID = Tickets.ticketID AND Tickets.status = " + "'" + selection1 + "'", conn);
                    SqlParameter id_param = new SqlParameter();
                    id_param.ParameterName = "@associateID";
                    id_param.Value = test.ToString();
                    id_cmd.Parameters.Add(id_param);
                    reader = id_cmd.ExecuteReader();

                    DataSet dsname2 = new DataSet();
                    DataTable dtname2 = new DataTable("Table3");
                    dsname2.Tables.Add(dtname2);
                    dsname2.Load(reader, LoadOption.PreserveChanges, dsname2.Tables[0]);
                    this.ticketsBindingSource.DataSource = dsname2.Tables[0];
                    dashboardGrid.DataSource = dsname2.Tables[0];
                }
                else if (statusOption.SelectedValue == null && equipmentOption.SelectedValue != null)
                {
                    SqlCommand cmd = new SqlCommand("SELECT associateID FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);
                    test = (Int32)cmd.ExecuteScalar();

                    SqlCommand cmd1 = new SqlCommand("SELECT equipmentID FROM Equipment WHERE equipmentDescription = @equipmentDescription", conn);
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@equipmentDescription";
                    param1.Value = equipmentOption.SelectedValue.ToString();
                    cmd1.Parameters.Add(param1);
                    test1 = (Int32)cmd1.ExecuteScalar();

                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets, Assignments, Equipment WHERE Assignments.associateID = @associateID AND Assignments.ticketID = Tickets.ticketID AND Equipment.equipmentID = @equipmentID and Tickets.equipmentID = @equipmentID", conn);
                    SqlParameter id_param = new SqlParameter();
                    SqlParameter id_param1 = new SqlParameter();
                    id_param.ParameterName = "@associateID";
                    id_param.Value = test.ToString();

                    id_param1.ParameterName = "@equipmentID";
                    id_param1.Value = test1.ToString();

                    id_cmd.Parameters.Add(id_param);
                    id_cmd.Parameters.Add(id_param1);
                    reader = id_cmd.ExecuteReader();

                    DataSet dsname3 = new DataSet();
                    DataTable dtname3 = new DataTable("Table5");
                    dsname3.Tables.Add(dtname3);
                    dsname3.Load(reader, LoadOption.PreserveChanges, dsname3.Tables[0]);
                    this.ticketsBindingSource.DataSource = dsname3.Tables[0];
                    dashboardGrid.DataSource = dsname3.Tables[0];
                }
                else if (statusOption.SelectedValue != null && equipmentOption.SelectedValue != null)
                {
                    string selection1 = statusOption.SelectedValue.ToString();

                    SqlCommand cmd = new SqlCommand("SELECT associateID FROM Users WHERE firstName = @firstName", conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@firstName";
                    param.Value = technicianOption.SelectedValue.ToString();
                    cmd.Parameters.Add(param);
                    test = (Int32)cmd.ExecuteScalar();

                    SqlCommand cmd1 = new SqlCommand("SELECT equipmentID FROM Equipment WHERE equipmentDescription = @equipmentDescription", conn);
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@equipmentDescription";
                    param1.Value = equipmentOption.SelectedValue.ToString();
                    cmd1.Parameters.Add(param1);
                    test1 = (Int32)cmd1.ExecuteScalar();

                    SqlCommand id_cmd = new SqlCommand("SELECT * FROM Tickets, Assignments, Equipment WHERE Assignments.associateID = @associateID AND Assignments.ticketID = Tickets.ticketID AND Equipment.equipmentID = @equipmentID and Tickets.equipmentID = @equipmentID  AND Tickets.status = " + "'" + selection1 + "'", conn);
                    SqlParameter id_param = new SqlParameter();
                    SqlParameter id_param1 = new SqlParameter();
                    id_param.ParameterName = "@associateID";
                    id_param.Value = test.ToString();

                    id_param1.ParameterName = "@equipmentID";
                    id_param1.Value = test1.ToString();

                    id_cmd.Parameters.Add(id_param);
                    id_cmd.Parameters.Add(id_param1);
                    reader = id_cmd.ExecuteReader();

                    DataSet dsname3 = new DataSet();
                    DataTable dtname3 = new DataTable("Table5");
                    dsname3.Tables.Add(dtname3);
                    dsname3.Load(reader, LoadOption.PreserveChanges, dsname3.Tables[0]);
                    this.ticketsBindingSource.DataSource = dsname3.Tables[0];
                    dashboardGrid.DataSource = dsname3.Tables[0];
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dashboardGrid.Refresh();
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
    }
}
