namespace banking
{
    partial class TransferForm
    {
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelReceiverUserId;
        private System.Windows.Forms.Label labelTransferAmount;
        private System.Windows.Forms.TextBox txtReceiverUserId;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.Button btnTransfer;

        private void InitializeComponent()
        {
            labelHeading = new Label();
            labelReceiverUserId = new Label();
            labelTransferAmount = new Label();
            txtReceiverUserId = new TextBox();
            txtTransferAmount = new TextBox();
            btnTransfer = new Button();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelHeading.ForeColor = Color.Navy;
            labelHeading.Location = new Point(247, 9);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(282, 48);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Transfer Money";
            // 
            // labelReceiverUserId
            // 
            labelReceiverUserId.AutoSize = true;
            labelReceiverUserId.Font = new Font("Segoe UI", 12F);
            labelReceiverUserId.Location = new Point(100, 100);
            labelReceiverUserId.Name = "labelReceiverUserId";
            labelReceiverUserId.Size = new Size(192, 32);
            labelReceiverUserId.TabIndex = 1;
            labelReceiverUserId.Text = "Receiver User ID:";
            // 
            // labelTransferAmount
            // 
            labelTransferAmount.AutoSize = true;
            labelTransferAmount.Font = new Font("Segoe UI", 12F);
            labelTransferAmount.Location = new Point(100, 150);
            labelTransferAmount.Name = "labelTransferAmount";
            labelTransferAmount.Size = new Size(196, 32);
            labelTransferAmount.TabIndex = 3;
            labelTransferAmount.Text = "Transfer Amount:";
            // 
            // txtReceiverUserId
            // 
            txtReceiverUserId.Font = new Font("Segoe UI", 12F);
            txtReceiverUserId.Location = new Point(379, 93);
            txtReceiverUserId.Name = "txtReceiverUserId";
            txtReceiverUserId.Size = new Size(300, 39);
            txtReceiverUserId.TabIndex = 2;
            // 
            // txtTransferAmount
            // 
            txtTransferAmount.Font = new Font("Segoe UI", 12F);
            txtTransferAmount.Location = new Point(379, 155);
            txtTransferAmount.Name = "txtTransferAmount";
            txtTransferAmount.Size = new Size(300, 39);
            txtTransferAmount.TabIndex = 4;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.MediumSeaGreen;
            btnTransfer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.Location = new Point(270, 200);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(150, 40);
            btnTransfer.TabIndex = 5;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelHeading);
            Controls.Add(labelReceiverUserId);
            Controls.Add(txtReceiverUserId);
            Controls.Add(labelTransferAmount);
            Controls.Add(txtTransferAmount);
            Controls.Add(btnTransfer);
            Name = "TransferForm";
            Text = "TransferForm";
            Load += TransferForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
