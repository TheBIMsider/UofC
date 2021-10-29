namespace Asst5_Arrays_CStorms
{
    partial class frmTestResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadTestResults = new System.Windows.Forms.Button();
            this.btnProcessTestResults = new System.Windows.Forms.Button();
            this.txtResultsSummary = new System.Windows.Forms.RichTextBox();
            this.txtOutputSummary = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(27, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Results: Highest Grade, Lowest Grade, Average Grade";
            // 
            // btnLoadTestResults
            // 
            this.btnLoadTestResults.Location = new System.Drawing.Point(29, 21);
            this.btnLoadTestResults.Name = "btnLoadTestResults";
            this.btnLoadTestResults.Size = new System.Drawing.Size(290, 30);
            this.btnLoadTestResults.TabIndex = 2;
            this.btnLoadTestResults.Text = "Load Test Results";
            this.btnLoadTestResults.UseVisualStyleBackColor = true;
            this.btnLoadTestResults.Click += new System.EventHandler(this.btnLoadTestResults_Click_1);
            // 
            // btnProcessTestResults
            // 
            this.btnProcessTestResults.Location = new System.Drawing.Point(29, 228);
            this.btnProcessTestResults.Name = "btnProcessTestResults";
            this.btnProcessTestResults.Size = new System.Drawing.Size(288, 24);
            this.btnProcessTestResults.TabIndex = 3;
            this.btnProcessTestResults.Text = "Process Test Results";
            this.btnProcessTestResults.UseVisualStyleBackColor = true;
            this.btnProcessTestResults.Click += new System.EventHandler(this.btnProcessTestResults_Click);
            // 
            // txtResultsSummary
            // 
            this.txtResultsSummary.Location = new System.Drawing.Point(30, 83);
            this.txtResultsSummary.Name = "txtResultsSummary";
            this.txtResultsSummary.ReadOnly = true;
            this.txtResultsSummary.Size = new System.Drawing.Size(288, 128);
            this.txtResultsSummary.TabIndex = 4;
            this.txtResultsSummary.TabStop = false;
            this.txtResultsSummary.Text = "";
            // 
            // txtOutputSummary
            // 
            this.txtOutputSummary.Location = new System.Drawing.Point(30, 300);
            this.txtOutputSummary.Name = "txtOutputSummary";
            this.txtOutputSummary.ReadOnly = true;
            this.txtOutputSummary.Size = new System.Drawing.Size(282, 53);
            this.txtOutputSummary.TabIndex = 5;
            this.txtOutputSummary.TabStop = false;
            this.txtOutputSummary.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(104, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Test Results per Student:";
            // 
            // txtLastNumber
            // 
            this.txtLastNumber.Location = new System.Drawing.Point(32, 368);
            this.txtLastNumber.Name = "txtLastNumber";
            this.txtLastNumber.ReadOnly = true;
            this.txtLastNumber.Size = new System.Drawing.Size(279, 20);
            this.txtLastNumber.TabIndex = 7;
            this.txtLastNumber.Visible = false;
            // 
            // frmTestResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 366);
            this.Controls.Add(this.txtLastNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputSummary);
            this.Controls.Add(this.txtResultsSummary);
            this.Controls.Add(this.btnProcessTestResults);
            this.Controls.Add(this.btnLoadTestResults);
            this.Controls.Add(this.label1);
            this.Name = "frmTestResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadTestResults;
        private System.Windows.Forms.Button btnProcessTestResults;
        private System.Windows.Forms.RichTextBox txtResultsSummary;
        private System.Windows.Forms.RichTextBox txtOutputSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastNumber;
    }
}

