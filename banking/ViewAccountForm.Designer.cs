namespace banking
{
    partial class ViewAccountForm
    {
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBalance;

        private void InitializeComponent()
        {
            labelHeading = new Label();
            labelUserId = new Label();
            labelUsername = new Label();
            labelEmail = new Label();
            labelBalance = new Label();
            txtUserId = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtBalance = new TextBox();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelHeading.ForeColor = Color.Navy;
            labelHeading.Location = new Point(739, 30);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(220, 48);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "User Details";
            // 
            // labelUserId
            // 
            labelUserId.AutoSize = true;
            labelUserId.Font = new Font("Segoe UI", 12F);
            labelUserId.Location = new Point(626, 124);
            labelUserId.Name = "labelUserId";
            labelUserId.Size = new Size(86, 32);
            labelUserId.TabIndex = 1;
            labelUserId.Text = "UserId:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F);
            labelUsername.Location = new Point(597, 207);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(126, 32);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(636, 289);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(76, 32);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email:";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 12F);
            labelBalance.Location = new Point(611, 372);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(101, 32);
            labelBalance.TabIndex = 7;
            labelBalance.Text = "Balance:";
            // 
            // txtUserId
            // 
            txtUserId.Font = new Font("Segoe UI", 12F);
            txtUserId.Location = new Point(943, 124);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(300, 39);
            txtUserId.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(943, 200);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(300, 39);
            txtUsername.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(943, 289);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(300, 39);
            txtEmail.TabIndex = 6;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 12F);
            txtBalance.Location = new Point(943, 369);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(300, 39);
            txtBalance.TabIndex = 8;
            // 
            // ViewAccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1756, 570);
            Controls.Add(labelHeading);
            Controls.Add(labelUserId);
            Controls.Add(txtUserId);
            Controls.Add(labelUsername);
            Controls.Add(txtUsername);
            Controls.Add(labelEmail);
            Controls.Add(txtEmail);
            Controls.Add(labelBalance);
            Controls.Add(txtBalance);
            Name = "ViewAccountForm";
            Text = "ViewAccountForm";
            Load += ViewAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
