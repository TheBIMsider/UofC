namespace Asst2_ProgramingLogic_CStorms
{
    partial class frmGradeCalculator
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
            this.txtGradeInput = new System.Windows.Forms.TextBox();
            this.btnInputGrades = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSummaryOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Input Grades Here:";
            // 
            // txtGradeInput
            // 
            this.txtGradeInput.Location = new System.Drawing.Point(157, 71);
            this.txtGradeInput.Name = "txtGradeInput";
            this.txtGradeInput.Size = new System.Drawing.Size(223, 20);
            this.txtGradeInput.TabIndex = 1;
            // 
            // btnInputGrades
            // 
            this.btnInputGrades.Location = new System.Drawing.Point(43, 128);
            this.btnInputGrades.Name = "btnInputGrades";
            this.btnInputGrades.Size = new System.Drawing.Size(150, 50);
            this.btnInputGrades.TabIndex = 2;
            this.btnInputGrades.Text = "Add Grade";
            this.btnInputGrades.UseVisualStyleBackColor = true;
            this.btnInputGrades.Click += new System.EventHandler(this.btnInputGrades_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(230, 128);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 50);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "High Grade, Low Grade, Average Grade:";
            // 
            // txtSummaryOutput
            // 
            this.txtSummaryOutput.Location = new System.Drawing.Point(43, 254);
            this.txtSummaryOutput.Multiline = true;
            this.txtSummaryOutput.Name = "txtSummaryOutput";
            this.txtSummaryOutput.ReadOnly = true;
            this.txtSummaryOutput.Size = new System.Drawing.Size(337, 141);
            this.txtSummaryOutput.TabIndex = 5;
            this.txtSummaryOutput.TextChanged += new System.EventHandler(this.txtSummaryOutput_TextChanged);
            // 
            // frmGradeCalculator
            // 
            this.AcceptButton = this.btnInputGrades;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 419);
            this.Controls.Add(this.txtSummaryOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnInputGrades);
            this.Controls.Add(this.txtGradeInput);
            this.Controls.Add(this.label1);
            this.Name = "frmGradeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGradeInput;
        private System.Windows.Forms.Button btnInputGrades;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSummaryOutput;
    }
}

