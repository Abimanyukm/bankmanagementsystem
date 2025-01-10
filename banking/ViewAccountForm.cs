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

namespace banking
{
    public partial class ViewAccountForm : Form
    {
        public ViewAccountForm()
        {
            InitializeComponent();
        }

        private void ViewAccountForm_Load(object sender, EventArgs e)
        {
            LoadAccountDetails();
        }

        private void LoadAccountDetails()
        {
            int userId = SessionManager.UserId;  // Assuming SessionManager is managing the session
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=banking;Integrated Security=True;";
            string query = "SELECT Accounts.UserId, Accounts.Balance, Users.Username, Users.Email " +
                           "FROM Accounts " +
                           "INNER JOIN Users ON Accounts.UserId = Users.UserId " +
                           "WHERE Accounts.UserId = @UserId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtUserId.Text = reader["UserId"].ToString();
                        txtUsername.Text = reader["Username"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtBalance.Text = reader["Balance"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
