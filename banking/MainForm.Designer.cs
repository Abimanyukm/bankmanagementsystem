namespace banking
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

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
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.Navy;
            label1.Location = new System.Drawing.Point(330, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(808, 65);
            label1.TabIndex = 2;
            label1.Text = "BANKING MANAGEMENT SYSTEM";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Padding = new System.Windows.Forms.Padding(10);
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(340, 309);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(157, 34);
            button1.TabIndex = 0;
            button1.Text = "ADMIN LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            button1.BackColor = System.Drawing.Color.LightSteelBlue;
            button1.Click += button1_Click;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(959, 309);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(147, 34);
            button2.TabIndex = 1;
            button2.Text = "USER LOGIN";
            button2.UseVisualStyleBackColor = true;
            button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            button2.BackColor = System.Drawing.Color.LightSteelBlue;
            button2.Click += button2_Click;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1472, 685);
            BackColor = System.Drawing.Color.AliceBlue;
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
