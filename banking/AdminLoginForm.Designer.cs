namespace banking
{
    partial class AdminLoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Label lblSubHeading;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnGoBack = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            lblMainHeading = new Label();
            lblSubHeading = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(873, 225);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(231, 31);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(873, 321);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(231, 31);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightGreen;
            btnLogin.Location = new Point(698, 379);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.LightCoral;
            btnGoBack.Location = new Point(12, 12);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(94, 29);
            btnGoBack.TabIndex = 3;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.DarkBlue;
            lblUsername.Location = new Point(554, 228);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.DarkBlue;
            lblPassword.Location = new Point(558, 321);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblMainHeading
            // 
            lblMainHeading.AutoSize = true;
            lblMainHeading.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblMainHeading.ForeColor = Color.Navy;
            lblMainHeading.Location = new Point(449, 22);
            lblMainHeading.Name = "lblMainHeading";
            lblMainHeading.Size = new Size(808, 65);
            lblMainHeading.TabIndex = 6;
            lblMainHeading.Text = "BANKING MANAGEMENT SYSTEM";
            lblMainHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSubHeading.ForeColor = Color.DarkGreen;
            lblSubHeading.Location = new Point(674, 87);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(236, 48);
            lblSubHeading.TabIndex = 7;
            lblSubHeading.Text = "Admin Login";
            lblSubHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1817, 600);
            Controls.Add(lblSubHeading);
            Controls.Add(lblMainHeading);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnGoBack);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "AdminLoginForm";
            Text = "AdminLoginForm";
            Load += AdminLoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
