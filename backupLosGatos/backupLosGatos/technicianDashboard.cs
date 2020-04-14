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
    public partial class technicianDashboard : Form
    {
        public technicianDashboard()
        {
            InitializeComponent();
        }

        private void technicianDashboard_Load(object sender, EventArgs e)
        {
            this.assignmentsTableAdapter.Fill(this.gROUP6DataSet.Assignments);
            this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
