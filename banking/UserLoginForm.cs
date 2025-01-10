using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace banking
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=banking;Integrated Security=True;";
            string query = "SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int userId = reader.GetInt32(0); // Assuming UserID is an int

                        // Set the session userId
                        SessionManager.UserId = userId;

                        // Navigate to UserDashboard
                        UserDashboard userDashboard = new UserDashboard();
                        userDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials.");
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
