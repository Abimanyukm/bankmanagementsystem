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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int senderId = SessionManager.UserId;  // Assuming SessionManager is managing the session
            string receiverId = txtReceiverUserId.Text;
            string transferAmountStr = txtTransferAmount.Text;

            if (decimal.TryParse(transferAmountStr, out decimal transferAmount) && transferAmount > 0)
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=banking;Integrated Security=True;";
                string querySelectSender = "SELECT Balance FROM Accounts WHERE UserId = @UserId";
                string querySelectReceiver = "SELECT Balance FROM Accounts WHERE UserId = @ReceiverId";
                string queryUpdateSender = "UPDATE Accounts SET Balance = @NewBalance WHERE UserId = @UserId";
                string queryUpdateReceiver = "UPDATE Accounts SET Balance = @NewBalance WHERE UserId = @ReceiverId";
                string queryInsertTransaction = "INSERT INTO Transactions (SenderID, ReceiverID, Amount, TransactionDate) VALUES (@SenderID, @ReceiverID, @Amount, @TransactionDate)";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Retrieve the sender's current balance
                        SqlCommand cmdSelectSender = new SqlCommand(querySelectSender, conn);
                        cmdSelectSender.Parameters.AddWithValue("@UserId", senderId);
                        string senderBalanceStr = cmdSelectSender.ExecuteScalar()?.ToString() ?? "0";
                        decimal senderBalance = decimal.Parse(senderBalanceStr);

                        // Check if the sender has sufficient funds
                        if (senderBalance >= transferAmount)
                        {
                            // Retrieve the receiver's current balance
                            SqlCommand cmdSelectReceiver = new SqlCommand(querySelectReceiver, conn);
                            cmdSelectReceiver.Parameters.AddWithValue("@ReceiverId", receiverId);
                            string receiverBalanceStr = cmdSelectReceiver.ExecuteScalar()?.ToString() ?? "0";
                            decimal receiverBalance = decimal.Parse(receiverBalanceStr);

                            // Calculate the new balances
                            decimal newSenderBalance = senderBalance - transferAmount;
                            decimal newReceiverBalance = receiverBalance + transferAmount;

                            // Update the sender's balance
                            SqlCommand cmdUpdateSender = new SqlCommand(queryUpdateSender, conn);
                            cmdUpdateSender.Parameters.AddWithValue("@NewBalance", newSenderBalance.ToString());
                            cmdUpdateSender.Parameters.AddWithValue("@UserId", senderId);
                            cmdUpdateSender.ExecuteNonQuery();

                            // Update the receiver's balance
                            SqlCommand cmdUpdateReceiver = new SqlCommand(queryUpdateReceiver, conn);
                            cmdUpdateReceiver.Parameters.AddWithValue("@NewBalance", newReceiverBalance.ToString());
                            cmdUpdateReceiver.Parameters.AddWithValue("@ReceiverId", receiverId);
                            cmdUpdateReceiver.ExecuteNonQuery();

                            // Insert the transaction record
                            SqlCommand cmdInsertTransaction = new SqlCommand(queryInsertTransaction, conn);
                            cmdInsertTransaction.Parameters.AddWithValue("@SenderID", senderId);
                            cmdInsertTransaction.Parameters.AddWithValue("@ReceiverID", receiverId);
                            cmdInsertTransaction.Parameters.AddWithValue("@Amount", transferAmount.ToString());
                            cmdInsertTransaction.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                            cmdInsertTransaction.ExecuteNonQuery();

                            MessageBox.Show("Transfer successful.");
                        }
                        else
                        {
                            MessageBox.Show("Insufficient funds for this transfer.");
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
                MessageBox.Show("Please enter a valid transfer amount.");
            }
        }
    }
}
