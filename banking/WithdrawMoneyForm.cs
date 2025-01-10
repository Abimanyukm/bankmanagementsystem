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
    public partial class WithdrawMoneyForm : Form
    {
        public WithdrawMoneyForm()
        {
            InitializeComponent();
        }

        private void WithdrawMoneyForm_Load(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int userId = SessionManager.UserId;  // Assuming SessionManager is managing the session
            string withdrawAmountStr = txtWithdrawAmount.Text;

            if (decimal.TryParse(withdrawAmountStr, out decimal withdrawAmount) && withdrawAmount > 0)
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=banking;Integrated Security=True;";
                string querySelect = "SELECT Balance FROM Accounts WHERE UserId = @UserId";
                string queryUpdate = "UPDATE Accounts SET Balance = @NewBalance WHERE UserId = @UserId";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Retrieve the current balance
                        SqlCommand cmdSelect = new SqlCommand(querySelect, conn);
                        cmdSelect.Parameters.AddWithValue("@UserId", userId);
                        string currentBalanceStr = cmdSelect.ExecuteScalar()?.ToString() ?? "0";
                        decimal currentBalance = decimal.Parse(currentBalanceStr);

                        // Check if there are sufficient funds
                        if (currentBalance >= withdrawAmount)
                        {
                            // Calculate the new balance
                            decimal newBalance = currentBalance - withdrawAmount;

                            // Update the balance
                            SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                            cmdUpdate.Parameters.AddWithValue("@NewBalance", newBalance.ToString());
                            cmdUpdate.Parameters.AddWithValue("@UserId", userId);
                            cmdUpdate.ExecuteNonQuery();

                            MessageBox.Show("Withdrawal successful.");
                        }
                        else
                        {
                            MessageBox.Show("Insufficient funds for this withdrawal.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid withdrawal amount.");
            }
        }
    }
}
