namespace banking
{
    partial class AddBankAccountForm
    {
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelDepositBalance;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtDepositBalance;
        private System.Windows.Forms.Button btnAddAccount;

        private void InitializeComponent()
        {
            labelHeading = new Label();
            labelUserId = new Label();
            labelDepositBalance = new Label();
            txtUserId = new TextBox();
            txtDepositBalance = new TextBox();
            btnAddAccount = new Button();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelHeading.ForeColor = Color.Navy;
            labelHeading.Location = new Point(635, 34);
            labelHeading.Margin = new Padding(4, 0, 4, 0);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(332, 48);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Add Bank Account";
            // 
            // labelUserId
            // 
            labelUserId.AutoSize = true;
            labelUserId.Font = new Font("Segoe UI", 12F);
            labelUserId.Location = new Point(612, 143);
            labelUserId.Margin = new Padding(4, 0, 4, 0);
            labelUserId.Name = "labelUserId";
            labelUserId.Size = new Size(86, 32);
            labelUserId.TabIndex = 1;
            labelUserId.Text = "UserId:";
            // 
            // labelDepositBalance
            // 
            labelDepositBalance.AutoSize = true;
            labelDepositBalance.Font = new Font("Segoe UI", 12F);
            labelDepositBalance.Location = new Point(508, 228);
            labelDepositBalance.Margin = new Padding(4, 0, 4, 0);
            labelDepositBalance.Name = "labelDepositBalance";
            labelDepositBalance.Size = new Size(190, 32);
            labelDepositBalance.TabIndex = 3;
            labelDepositBalance.Text = "Deposit Balance:";
            // 
            // txtUserId
            // 
            txtUserId.Font = new Font("Segoe UI", 12F);
            txtUserId.Location = new Point(907, 143);
            txtUserId.Margin = new Padding(4, 4, 4, 4);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(374, 39);
            txtUserId.TabIndex = 2;
            // 
            // txtDepositBalance
            // 
            txtDepositBalance.Font = new Font("Segoe UI", 12F);
            txtDepositBalance.Location = new Point(907, 225);
            txtDepositBalance.Margin = new Padding(4, 4, 4, 4);
            txtDepositBalance.Name = "txtDepositBalance";
            txtDepositBalance.Size = new Size(374, 39);
            txtDepositBalance.TabIndex = 4;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = Color.MediumSeaGreen;
            btnAddAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddAccount.ForeColor = Color.White;
            btnAddAccount.Location = new Point(728, 312);
            btnAddAccount.Margin = new Padding(4, 4, 4, 4);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(188, 50);
            btnAddAccount.TabIndex = 5;
            btnAddAccount.Text = "Add Account";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // AddBankAccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1828, 562);
            Controls.Add(labelHeading);
            Controls.Add(labelUserId);
            Controls.Add(txtUserId);
            Controls.Add(labelDepositBalance);
            Controls.Add(txtDepositBalance);
            Controls.Add(btnAddAccount);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddBankAccountForm";
            Text = "AddBankAccountForm";
            Load += AddBankAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
