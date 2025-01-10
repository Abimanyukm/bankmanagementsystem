namespace banking
{
    partial class DepositMoneyForm
    {
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelDepositAmount;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Button btnDeposit;

        private void InitializeComponent()
        {
            labelHeading = new Label();
            labelDepositAmount = new Label();
            txtDepositAmount = new TextBox();
            btnDeposit = new Button();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelHeading.ForeColor = Color.Navy;
            labelHeading.Location = new Point(719, 37);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(276, 48);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Deposit Money";
            // 
            // labelDepositAmount
            // 
            labelDepositAmount.AutoSize = true;
            labelDepositAmount.Font = new Font("Segoe UI", 12F);
            labelDepositAmount.Location = new Point(554, 144);
            labelDepositAmount.Name = "labelDepositAmount";
            labelDepositAmount.Size = new Size(194, 32);
            labelDepositAmount.TabIndex = 1;
            labelDepositAmount.Text = "Deposit Amount:";
            // 
            // txtDepositAmount
            // 
            txtDepositAmount.Font = new Font("Segoe UI", 12F);
            txtDepositAmount.Location = new Point(952, 137);
            txtDepositAmount.Name = "txtDepositAmount";
            txtDepositAmount.Size = new Size(300, 39);
            txtDepositAmount.TabIndex = 2;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.MediumSeaGreen;
            btnDeposit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(781, 258);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(150, 40);
            btnDeposit.TabIndex = 3;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // DepositMoneyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1826, 489);
            Controls.Add(labelHeading);
            Controls.Add(labelDepositAmount);
            Controls.Add(txtDepositAmount);
            Controls.Add(btnDeposit);
            Name = "DepositMoneyForm";
            Text = "DepositMoneyForm";
            Load += DepositMoneyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
