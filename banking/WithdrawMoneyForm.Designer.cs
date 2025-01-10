namespace banking
{
    partial class WithdrawMoneyForm
    {
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelWithdrawAmount;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.Button btnWithdraw;

        private void InitializeComponent()
        {
            labelHeading = new Label();
            labelWithdrawAmount = new Label();
            txtWithdrawAmount = new TextBox();
            btnWithdraw = new Button();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelHeading.ForeColor = Color.Navy;
            labelHeading.Location = new Point(630, 59);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(312, 48);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Withdraw Money";
            // 
            // labelWithdrawAmount
            // 
            labelWithdrawAmount.AutoSize = true;
            labelWithdrawAmount.Font = new Font("Segoe UI", 12F);
            labelWithdrawAmount.Location = new Point(500, 174);
            labelWithdrawAmount.Name = "labelWithdrawAmount";
            labelWithdrawAmount.Size = new Size(213, 32);
            labelWithdrawAmount.TabIndex = 1;
            labelWithdrawAmount.Text = "Withdraw Amount:";
            // 
            // txtWithdrawAmount
            // 
            txtWithdrawAmount.Font = new Font("Segoe UI", 12F);
            txtWithdrawAmount.Location = new Point(860, 171);
            txtWithdrawAmount.Name = "txtWithdrawAmount";
            txtWithdrawAmount.Size = new Size(300, 39);
            txtWithdrawAmount.TabIndex = 2;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.MediumSeaGreen;
            btnWithdraw.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnWithdraw.ForeColor = Color.White;
            btnWithdraw.Location = new Point(721, 269);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(150, 40);
            btnWithdraw.TabIndex = 3;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // WithdrawMoneyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1828, 450);
            Controls.Add(labelHeading);
            Controls.Add(labelWithdrawAmount);
            Controls.Add(txtWithdrawAmount);
            Controls.Add(btnWithdraw);
            Name = "WithdrawMoneyForm";
            Text = "WithdrawMoneyForm";
            Load += WithdrawMoneyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
