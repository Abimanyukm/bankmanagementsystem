using System;
using System.Windows.Forms;

namespace banking
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            int userId = SessionManager.UserId;
        }

        private void viewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAccountForm viewAccountForm = new ViewAccountForm();
            viewAccountForm.Show();
        }

        private void depositMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositMoneyForm depositMoneyForm = new DepositMoneyForm();
            depositMoneyForm.Show();
        }

        private void withdrawMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawMoneyForm withdrawMoneyForm = new WithdrawMoneyForm();
            withdrawMoneyForm.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.Show();
        }

        private void transactionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm transactionHistoryForm = new TransactionHistoryForm();
            transactionHistoryForm.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDetailsForm updateDetailsForm = new UpdateDetailsForm();
            updateDetailsForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Clear the session username
                SessionManager.UserId = 0;

                // Navigate back to UserLoginForm
                UserLoginForm userLoginForm = new UserLoginForm();
                userLoginForm.Show();
                this.Close();
            }
        }
    }
}
