namespace banking
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addBankAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDeleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcomeMessage;

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
            menuStrip1 = new MenuStrip();
            addBankAccountToolStripMenuItem = new ToolStripMenuItem();
            editDeleteAccountToolStripMenuItem = new ToolStripMenuItem();
            viewTransactionToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            lblWelcomeMessage = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addBankAccountToolStripMenuItem, editDeleteAccountToolStripMenuItem, viewTransactionToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addBankAccountToolStripMenuItem
            // 
            addBankAccountToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            addBankAccountToolStripMenuItem.ForeColor = Color.DarkBlue;
            addBankAccountToolStripMenuItem.Name = "addBankAccountToolStripMenuItem";
            addBankAccountToolStripMenuItem.Size = new Size(226, 36);
            addBankAccountToolStripMenuItem.Text = "Add Bank Account";
            addBankAccountToolStripMenuItem.Click += addBankAccountToolStripMenuItem_Click;
            // 
            // editDeleteAccountToolStripMenuItem
            // 
            editDeleteAccountToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            editDeleteAccountToolStripMenuItem.ForeColor = Color.DarkBlue;
            editDeleteAccountToolStripMenuItem.Name = "editDeleteAccountToolStripMenuItem";
            editDeleteAccountToolStripMenuItem.Size = new Size(243, 36);
            editDeleteAccountToolStripMenuItem.Text = "Edit/Delete Account";
            editDeleteAccountToolStripMenuItem.Click += editDeleteAccountToolStripMenuItem_Click;
            // 
            // viewTransactionToolStripMenuItem
            // 
            viewTransactionToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            viewTransactionToolStripMenuItem.ForeColor = Color.DarkBlue;
            viewTransactionToolStripMenuItem.Name = "viewTransactionToolStripMenuItem";
            viewTransactionToolStripMenuItem.Size = new Size(208, 36);
            viewTransactionToolStripMenuItem.Text = "View Transaction";
            viewTransactionToolStripMenuItem.Click += viewTransactionToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            logoutToolStripMenuItem.ForeColor = Color.DarkRed;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(105, 36);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblWelcomeMessage.ForeColor = Color.DarkGreen;
            lblWelcomeMessage.Location = new Point(12, 50);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(195, 48);
            lblWelcomeMessage.TabIndex = 1;
            lblWelcomeMessage.Text = "Welcome,Admin";
            lblWelcomeMessage.Click += lblWelcomeMessage_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1000, 600);
            Controls.Add(lblWelcomeMessage);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
