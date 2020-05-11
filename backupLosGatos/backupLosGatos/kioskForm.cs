using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace backupLosGatos
{
    public partial class kioskForm : Form
    {
        public kioskForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipmentCombo.Enabled = true;
            equipmentCombo.Items.Clear();
            equipmentCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            if (unitCombo.SelectedIndex == 0)
            {
                equipmentCombo.Items.Add(1);
                equipmentCombo.Items.Add(2);
                equipmentCombo.Items.Add(3);
                equipmentCombo.Items.Add(4);
            }
            if (unitCombo.SelectedIndex == 1)
            {
                equipmentCombo.Items.Add(5);
                equipmentCombo.Items.Add(6);
                equipmentCombo.Items.Add(7);
                equipmentCombo.Items.Add(8); ;
            }
            if (unitCombo.SelectedIndex == 2)
            {
                equipmentCombo.Items.Add(9);
                equipmentCombo.Items.Add(10);
                equipmentCombo.Items.Add(11);
                equipmentCombo.Items.Add(12);
            }
            if (unitCombo.SelectedIndex == 3)
            {
                equipmentCombo.Items.Add(13);
                equipmentCombo.Items.Add(14);
                equipmentCombo.Items.Add(15);
                equipmentCombo.Items.Add(16);
            }
        }

        private void equipmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            priorityCombo.Enabled = true;
        }

        private void priorityCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit ticket?", "Ticket Submission", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source = 10.135.85.184; Initial Catalog = GROUP6; Persist Security Info = True; User ID = Group6; Password = Grp6s2117; MultipleActiveResultSets=true");
                DateTime thisDay = DateTime.Today;
                int numID = 0;

                SqlCommand cmd = new SqlCommand("sp_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dateSubmitted", thisDay);
                cmd.Parameters.AddWithValue("@unitID", unitCombo.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@equipmentID", equipmentCombo.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@priorityLevel", priorityCombo.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@technicianName", employeeText.Text.ToString());
                cmd.Parameters.AddWithValue("@additionalInformation", additionalInfo.Text.ToString());

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i != 0)
                {
                    MessageBox.Show("Your ticket has been submitted.");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                unitCombo.SelectedIndex = -1;
                priorityCombo.SelectedIndex = -1;
                priorityCombo.Enabled = false;
                equipmentCombo.Enabled = false;
                employeeText.Text = "";
                additionalInfo.Text = "";
                unitCombo.Select();
            }

        }

        private void employeeText_TextChanged(object sender, EventArgs e)
        {
            if (employeeText.Text.Trim().Length > 0)
            {
                submitButton.Enabled = true;
            }
            else if (employeeText.Text.Trim().Length == 0)
            {
                submitButton.Enabled = false;
            }
        }
    }
}
