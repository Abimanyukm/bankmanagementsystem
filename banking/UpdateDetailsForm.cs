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
    public partial class UpdateDetailsForm : Form
    {
        public UpdateDetailsForm()
        {
            InitializeComponent();
        }

        private void UpdateDetailsForm_Load(object sender, EventArgs e)
        {
            LoadUserDetails();
        }

        private void LoadUserDetails()
        {
            int userId = SessionManager.UserId;  // Assuming SessionManager is managing the session
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=banking;Integrated Security=True;";
            string query = "SELECT Username, Password, Email FROM Users WHERE UserID = @UserID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtUsername.Text = reader["Username"].ToString();
                        txtPassword.Text = reader["Password"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int userId = SessionManager.UserId;  // Assuming SessionManager is managing the session
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=banking;Integrated Security=True;";
            string query = "UPDATE Users SET Username = @Username, Password = @Password, Email = @Email WHERE UserID = @UserID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
