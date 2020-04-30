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
            // TODO: This line of code loads data into the 'gROUP6DataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.gROUP6DataSet.Tickets);
            conn = new
            SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");
            conn.Open();

            //SqlCommand cmd = new SqlCommand("SELECT DISTINCT status FROM dbo.Tickets", conn);
            //reader = cmd.ExecuteReader();
            //DataSet dsstatus = new DataSet();
            //DataTable dtstatus = new DataTable("Table1");
            //dsstatus.Tables.Add(dtstatus);
            //dsstatus.Load(reader, LoadOption.PreserveChanges, dsstatus.Tables[0]);

            //statusOption.ValueMember = "status";
            //statusOption.DisplayMember = "status";
            //statusOption.DataSource = dsstatus.Tables[0];
            //statusOption.SelectedIndex = 0;
            //statusOption.SelectedValue = 0;

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

        //private void statusOption_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (statusOption.SelectedValue == null)
        //    {
        //    }
        //    else
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets WHERE status = @status", conn);
        //        SqlParameter param = new SqlParameter();
        //        param.ParameterName = "@status";
        //        param.Value = statusOption.SelectedValue.ToString();
        //        cmd.Parameters.Add(param);

        //        reader = cmd.ExecuteReader();

        //        DataSet ds = new DataSet();
        //        DataTable dt = new DataTable("Table1");
        //        ds.Tables.Add(dt);
        //        ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);

        //        dashboardGrid.DataSource = ds.Tables[0];
        //    }
        //}
    }
}
