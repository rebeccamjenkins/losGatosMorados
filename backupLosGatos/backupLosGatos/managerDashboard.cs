using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backupLosGatos
{
    public partial class managerDashboard : Form
    {
        public managerDashboard()
        {
            InitializeComponent();
        }

        private void managerDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP6DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gROUP6DataSet.Users);
            this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);
        }

        public static DataGridViewRow selectedRow { get; set; }
        private void managerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = managerGrid.Rows[e.RowIndex];
                ticketDetails ticketDetails = new ticketDetails();
                ticketDetails.Show();
            }
        }
    }
}
