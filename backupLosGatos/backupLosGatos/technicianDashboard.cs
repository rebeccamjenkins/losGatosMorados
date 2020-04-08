using System;
using System.Windows.Forms;

namespace backupLosGatos
{
    public partial class technicianDashboard : Form
    {
        public technicianDashboard()
        {
            InitializeComponent();
        }

        private void technicianDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP6DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gROUP6DataSet.Users);
            this.assignmentsTableAdapter.Fill(this.gROUP6DataSet.Assignments);
            this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);
        }

        public static DataGridViewRow selectedRow { get; set; }

        private void technicianGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    selectedRow = technicianGrid.Rows[e.RowIndex];
            //    ticketDetails ticketDetails = new ticketDetails();
            //    ticketDetails.Show();
            //}
        }
    }
}
