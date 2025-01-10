namespace banking
{
    partial class ViewTransactionForm
    {
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.Button btnExportToText;

        private void InitializeComponent()
        {
            this.labelHeading = new System.Windows.Forms.Label();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.btnExportToText = new System.Windows.Forms.Button();

            SuspendLayout();

            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(300, 20);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(263, 41);
            this.labelHeading.TabIndex = 0;
            this.labelHeading.Text = "Transaction History";

            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(50, 80);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.RowHeadersWidth = 51;
            this.dataGridViewTransactions.RowTemplate.Height = 29;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(700, 350);
            this.dataGridViewTransactions.TabIndex = 1;

            // 
            // btnExportToText
            // 
            this.btnExportToText.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExportToText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportToText.ForeColor = System.Drawing.Color.White;
            this.btnExportToText.Location = new System.Drawing.Point(300, 450);
            this.btnExportToText.Name = "btnExportToText";
            this.btnExportToText.Size = new System.Drawing.Size(200, 40);
            this.btnExportToText.TabIndex = 2;
            this.btnExportToText.Text = "Export to Text";
            this.btnExportToText.UseVisualStyleBackColor = false;
            this.btnExportToText.Click += new System.EventHandler(this.btnExportToText_Click);

            // 
            // ViewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.dataGridViewTransactions);
            this.Controls.Add(this.btnExportToText);
            this.Name = "ViewTransactionForm";
            this.Text = "ViewTransactionForm";
            this.Load += new System.EventHandler(this.ViewTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
