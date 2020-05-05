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
            //this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);
            conn = new
            SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tickets, Assignments WHERE Assignments.associateID = @associateID AND Assignments.ticketID = Tickets.ticketID", conn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dashboardGrid.DataSource = data;
            conn.Close();

            foreach (DataGridViewRow row in dashboardGrid.Rows)
            {
                dashboardGrid.Rows[row.Index].Visible = !(row.Index > maxRows);
            }
        }

        private void ticketPage_Click(object sender, EventArgs e)
        {
            ticketDetails newTicket = new ticketDetails();
            newTicket.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
