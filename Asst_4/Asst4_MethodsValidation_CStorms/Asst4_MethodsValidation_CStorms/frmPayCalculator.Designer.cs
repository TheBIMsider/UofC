namespace Asst4_MethodsValidation_CStorms
{
    partial class frmPayCalculator
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
            this.txtSummaryOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtHoursPerWeek = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.btnCalculatePay = new System.Windows.Forms.Button();
            this.txtPayOutput = new System.Windows.Forms.TextBox();
            this.btnPaySummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSummaryOutput
            // 
            this.txtSummaryOutput.Location = new System.Drawing.Point(22, 254);
            this.txtSummaryOutput.Multiline = true;
            this.txtSummaryOutput.Name = "txtSummaryOutput";
            this.txtSummaryOutput.ReadOnly = true;
            this.txtSummaryOutput.Size = new System.Drawing.Size(307, 184);
            this.txtSummaryOutput.TabIndex = 0;
            this.txtSummaryOutput.TabStop = false;
            this.txtSummaryOutput.TextChanged += new System.EventHandler(this.txtSummaryOutput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hours Worked Per Week:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hourly Rate:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(179, 17);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(150, 20);
            this.txtEmployeeName.TabIndex = 1;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
            // 
            // txtHoursPerWeek
            // 
            this.txtHoursPerWeek.Location = new System.Drawing.Point(179, 59);
            this.txtHoursPerWeek.Name = "txtHoursPerWeek";
            this.txtHoursPerWeek.Size = new System.Drawing.Size(150, 20);
            this.txtHoursPerWeek.TabIndex = 2;
            this.txtHoursPerWeek.TextChanged += new System.EventHandler(this.txtHoursPerWeek_TextChanged);
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(179, 101);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(150, 20);
            this.txtHourlyRate.TabIndex = 3;
            this.txtHourlyRate.TextChanged += new System.EventHandler(this.txtHourlyRate_TextChanged);
            // 
            // btnCalculatePay
            // 
            this.btnCalculatePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePay.Location = new System.Drawing.Point(22, 148);
            this.btnCalculatePay.Name = "btnCalculatePay";
            this.btnCalculatePay.Size = new System.Drawing.Size(140, 25);
            this.btnCalculatePay.TabIndex = 7;
            this.btnCalculatePay.Text = "Calculate Pay";
            this.btnCalculatePay.UseVisualStyleBackColor = true;
            this.btnCalculatePay.Click += new System.EventHandler(this.btnCalculatePay_Click);
            // 
            // txtPayOutput
            // 
            this.txtPayOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayOutput.ForeColor = System.Drawing.Color.Blue;
            this.txtPayOutput.Location = new System.Drawing.Point(178, 151);
            this.txtPayOutput.Name = "txtPayOutput";
            this.txtPayOutput.ReadOnly = true;
            this.txtPayOutput.Size = new System.Drawing.Size(150, 20);
            this.txtPayOutput.TabIndex = 8;
            this.txtPayOutput.TabStop = false;
            this.txtPayOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayOutput.TextChanged += new System.EventHandler(this.txtPayOutput_TextChanged);
            // 
            // btnPaySummary
            // 
            this.btnPaySummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaySummary.Location = new System.Drawing.Point(22, 200);
            this.btnPaySummary.Name = "btnPaySummary";
            this.btnPaySummary.Size = new System.Drawing.Size(307, 27);
            this.btnPaySummary.TabIndex = 9;
            this.btnPaySummary.Text = "Biweekly Pay Summary";
            this.btnPaySummary.UseVisualStyleBackColor = true;
            this.btnPaySummary.Click += new System.EventHandler(this.btnPaySummary_Click);
            // 
            // frmPayCalculator
            // 
            this.AcceptButton = this.btnCalculatePay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 457);
            this.Controls.Add(this.btnPaySummary);
            this.Controls.Add(this.txtPayOutput);
            this.Controls.Add(this.btnCalculatePay);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtHoursPerWeek);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSummaryOutput);
            this.Name = "frmPayCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSummaryOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtHoursPerWeek;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Button btnCalculatePay;
        private System.Windows.Forms.TextBox txtPayOutput;
        private System.Windows.Forms.Button btnPaySummary;
    }
}

