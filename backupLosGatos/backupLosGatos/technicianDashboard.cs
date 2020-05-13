using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace backupLosGatos
{
    public partial class technicianDashboard : Form
    {
        private Int32 maxRows { get; set; }

        public technicianDashboard()
        {
            maxRows = 3;
            InitializeComponent();
        }

        SqlConnection conn = null;
        SqlDataReader reader = null;

        private void technicianDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP6DataSet11.Tickets' table. You can move, or remove it, as needed.
            //this.ticketsTableAdapter2.Fill(this.gROUP6DataSet11.Tickets);
            //this.ticketsTableAdapter1.Fill(this.gROUP6DataSet1.Tickets);
            //this.assignmentsTableAdapter.Fill(this.gROUP6DataSet.Assignments);
            conn = new
            SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");
            conn.Open();
            // 
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tickets WHERE userName = '" + techName.Text + "'", conn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dashboardGrid.DataSource = data;
            conn.Close();

            //foreach (DataGridViewRow row in dashboardGrid.Rows)
            //{
            //    dashboardGrid.Rows[row.Index].Visible = !(row.Index > maxRows);
            //}
        }

        private void ticketPage_Click(object sender, EventArgs e)
        {
            ticketDetails newTicket = new ticketDetails();
            newTicket.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginScreen newLogin = new loginScreen();
            newLogin.Show();
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            technicianDashboard tech = new technicianDashboard();
            tech.Show();
            this.Close();
        }

        private void dashboardPage_Click(object sender, EventArgs e)
        {
            technicianDashboard refresh = new technicianDashboard();
            this.Close();
            refresh.Show();
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            statusOption.Text = "";
            technicianOption.Text = "";
            equipmentOption.Text = "";
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

            viewTicket.submitButton.Visible = false;
            viewTicket.updateButton.Visible = true;
            viewTicket.saveButton.Visible = true;
            viewTicket.mangButton.Enabled = false;
            viewTicket.coordButton.Enabled = false;


            viewTicket.Show();
            this.Hide();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            queryTicket.Text = "";
        }
    }
}
