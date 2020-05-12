using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace backupLosGatos
{
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        int loginCount = 4;

        public static class userInfo
        {
            public static int coordUser = 1;
            public static int mangUser = 2;
            public static int techUser = 3;
        }
        public void submitButton_Click(object sender, EventArgs e)
        {
            Boolean userValid;

            if (loginCount > 1)
            {
                using (OleDbConnection myConnection = new OleDbConnection())
                {

                    myConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=10.135.85.184;User ID=Group6;Password=Grp6s2117;Initial Catalog=GROUP6";
                    myConnection.Open();
                    OleDbCommand cmdNotReturned = myConnection.CreateCommand();
                    cmdNotReturned.CommandText = "SELECT * FROM Users WHERE username = '" + usernameText.Text + "'AND password = '" + passwordText.Text + "'";

                    OleDbDataReader readerReturnValue = cmdNotReturned.ExecuteReader(CommandBehavior.CloseConnection);

                    if (readerReturnValue.HasRows == true)
                    {
                        OleDbCommand userType = myConnection.CreateCommand();
                        userType.CommandText = "SELECT userType FROM Users WHERE username = '" + usernameText.Text + "'";

                        OleDbDataReader userTypeReturn = userType.ExecuteReader();
                        technicianDashboard techName = new technicianDashboard();
                        techName.techName.Text = usernameText.Text;

                        while (userTypeReturn.Read())
                        {
                            int typeReturn = userTypeReturn.GetInt32(0);
                            //if the user is a coordinator
                            if (typeReturn == 1)
                            {
                                dashboardScreen dashboard = new dashboardScreen();
                                this.Hide();
                                dashboard.Show();
                            }
                            //if the user is a unit manager
                            else if (typeReturn == 2)
                            {
                                managerDashboard dashboard = new managerDashboard();
                                this.Hide();
                                dashboard.Show();
                            }
                            //if the user is a technician
                            else if (typeReturn == 3)
                            {
                                technicianDashboard dashboard = new technicianDashboard();
                                this.Hide();
                                dashboard.Show();
                            }
                            readerReturnValue = null;
                        }
                        technicianDashboard name = new technicianDashboard();
                        name.techName.Text = usernameText.Text;
                        userValid = true;
                        //MessageBox.Show("You have successfully logged in.");
                        userTypeReturn.Close();
                    }
                    else
                    {
                        loginCount--;
                        MessageBox.Show("Your login attempt has failed.  You have " + loginCount + " login attempt(s) left.");
                        usernameText.Clear();
                        passwordText.Clear();
                    }
                }
            }

            else if (loginCount == 1)
            {
                Application.Exit();
            }
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gROUP6DataSet);
        }

        private void loginScreen_Load(object sender, EventArgs e)
        {
            //this.usersTableAdapter.Fill(this.gROUP6DataSet.Users);
            usernameText.Text = "";
            passwordText.Text = "";
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitButton.PerformClick();
            }
        }
    }

}