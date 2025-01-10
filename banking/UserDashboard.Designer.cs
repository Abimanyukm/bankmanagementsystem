namespace banking
{
    partial class UserDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;

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
            viewAccountToolStripMenuItem = new ToolStripMenuItem();
            depositMoneyToolStripMenuItem = new ToolStripMenuItem();
            withdrawMoneyToolStripMenuItem = new ToolStripMenuItem();
            transferToolStripMenuItem = new ToolStripMenuItem();
            transactionHistoryToolStripMenuItem = new ToolStripMenuItem();
            updateDetailsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSteelBlue;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewAccountToolStripMenuItem, depositMoneyToolStripMenuItem, withdrawMoneyToolStripMenuItem, transferToolStripMenuItem, transactionHistoryToolStripMenuItem, updateDetailsToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1738, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewAccountToolStripMenuItem
            // 
            viewAccountToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            viewAccountToolStripMenuItem.ForeColor = Color.DarkBlue;
            viewAccountToolStripMenuItem.Name = "viewAccountToolStripMenuItem";
            viewAccountToolStripMenuItem.Size = new Size(175, 36);
            viewAccountToolStripMenuItem.Text = "View Account";
            viewAccountToolStripMenuItem.Click += viewAccountToolStripMenuItem_Click;
            // 
            // depositMoneyToolStripMenuItem
            // 
            depositMoneyToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            depositMoneyToolStripMenuItem.ForeColor = Color.DarkBlue;
            depositMoneyToolStripMenuItem.Name = "depositMoneyToolStripMenuItem";
            depositMoneyToolStripMenuItem.Size = new Size(194, 36);
            depositMoneyToolStripMenuItem.Text = "Deposit Money";
            depositMoneyToolStripMenuItem.Click += depositMoneyToolStripMenuItem_Click;
            // 
            // withdrawMoneyToolStripMenuItem
            // 
            withdrawMoneyToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            withdrawMoneyToolStripMenuItem.ForeColor = Color.DarkBlue;
            withdrawMoneyToolStripMenuItem.Name = "withdrawMoneyToolStripMenuItem";
            withdrawMoneyToolStripMenuItem.Size = new Size(213, 36);
            withdrawMoneyToolStripMenuItem.Text = "Withdraw Money";
            withdrawMoneyToolStripMenuItem.Click += withdrawMoneyToolStripMenuItem_Click;
            // 
            // transferToolStripMenuItem
            // 
            transferToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            transferToolStripMenuItem.ForeColor = Color.DarkBlue;
            transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            transferToolStripMenuItem.Size = new Size(114, 36);
            transferToolStripMenuItem.Text = "Transfer";
            transferToolStripMenuItem.Click += transferToolStripMenuItem_Click;
            // 
            // transactionHistoryToolStripMenuItem
            // 
            transactionHistoryToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            transactionHistoryToolStripMenuItem.ForeColor = Color.DarkBlue;
            transactionHistoryToolStripMenuItem.Name = "transactionHistoryToolStripMenuItem";
            transactionHistoryToolStripMenuItem.Size = new Size(232, 36);
            transactionHistoryToolStripMenuItem.Text = "Transaction History";
            transactionHistoryToolStripMenuItem.Click += transactionHistoryToolStripMenuItem_Click;
            // 
            // updateDetailsToolStripMenuItem
            // 
            updateDetailsToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            updateDetailsToolStripMenuItem.ForeColor = Color.DarkBlue;
            updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            updateDetailsToolStripMenuItem.Size = new Size(186, 36);
            updateDetailsToolStripMenuItem.Text = "Update Details";
            updateDetailsToolStripMenuItem.Click += updateDetailsToolStripMenuItem_Click;
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
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1738, 600);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "UserDashboard";
            Text = "UserDashboard";
            Load += UserDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
