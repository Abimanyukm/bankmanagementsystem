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
    public partial class AddBankAccountForm : Form
    {
        public AddBankAccountForm()
        {
            InitializeComponent();
        }

        private void AddBankAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            string depositBalance = txtDepositBalance.Text;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=banking;Integrated Security=True;";
            string query = "INSERT INTO Accounts (UserId, Balance) VALUES (@UserId, @Balance)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Balance", depositBalance);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
