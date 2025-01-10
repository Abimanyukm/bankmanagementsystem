using System;
using System.Windows.Forms;

namespace banking
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
        }

        private void addBankAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBankAccountForm addBankAccountForm = new AddBankAccountForm();
            addBankAccountForm.Show();
        }

        private void editDeleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDeleteAccountForm editDeleteAccountForm = new EditDeleteAccountForm();
            editDeleteAccountForm.Show();
        }

        private void viewTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTransactionForm viewTransactionForm = new ViewTransactionForm();
            viewTransactionForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AdminLoginForm adminLoginForm = new AdminLoginForm();
                adminLoginForm.Show();
                this.Close();
            }
        }

        private void lblWelcomeMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
