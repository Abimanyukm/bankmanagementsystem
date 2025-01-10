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
    public partial class EditDeleteAccountForm : Form
    {
        public EditDeleteAccountForm()
        {
            InitializeComponent();
        }

        private void EditDeleteAccountForm_Load(object sender, EventArgs e)
        {
            LoadAccountData();
        }

        private void LoadAccountData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=banking;Integrated Security=True;";
            string query = "SELECT * FROM Accounts";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewAccounts.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccounts.SelectedRows.Count > 0)
            {
                int accountId = Convert.ToInt32(dataGridViewAccounts.SelectedRows[0].Cells["AccountID"].Value);
                string userId = dataGridViewAccounts.SelectedRows[0].Cells["UserId"].Value.ToString();
                string balance = dataGridViewAccounts.SelectedRows[0].Cells["Balance"].Value.ToString();

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=banking;Integrated Security=True;";
                string query = "UPDATE Accounts SET UserId = @UserId, Balance = @Balance WHERE AccountID = @AccountID";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@Balance", balance);
                        cmd.Parameters.AddWithValue("@AccountID", accountId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account updated successfully.");
                        LoadAccountData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccounts.SelectedRows.Count > 0)
            {
                int accountId = Convert.ToInt32(dataGridViewAccounts.SelectedRows[0].Cells["AccountID"].Value);

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=banking;Integrated Security=True;";
                string query = "DELETE FROM Accounts WHERE AccountID = @AccountID";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@AccountID", accountId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account deleted successfully.");
                        LoadAccountData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
