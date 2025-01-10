namespace banking
{
    partial class UpdateDetailsForm
    {
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnUpdate;

        private void InitializeComponent()
        {
            labelHeading = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            labelEmail = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelHeading.ForeColor = Color.Navy;
            labelHeading.Location = new Point(782, 84);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(267, 48);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Update Details";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F);
            labelUsername.Location = new Point(630, 200);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(126, 32);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.Location = new Point(640, 313);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(116, 32);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(640, 409);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(76, 32);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(1063, 193);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 39);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(1063, 306);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 39);
            txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(1063, 392);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 39);
            txtEmail.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSeaGreen;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(847, 500);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 40);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdateDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1821, 688);
            Controls.Add(labelHeading);
            Controls.Add(labelUsername);
            Controls.Add(txtUsername);
            Controls.Add(labelPassword);
            Controls.Add(txtPassword);
            Controls.Add(labelEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnUpdate);
            Name = "UpdateDetailsForm";
            Text = "UpdateDetailsForm";
            Load += UpdateDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
