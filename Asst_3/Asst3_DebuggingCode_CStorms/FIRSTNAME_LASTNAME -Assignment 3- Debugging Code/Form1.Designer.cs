namespace Assignment_3__Debugging_Code
{
    partial class frmGradePoint
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnInputGrade = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 20);
            this.txtName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grade:";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(78, 52);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(178, 20);
            this.txtGrade.TabIndex = 20;
            // 
            // btnInputGrade
            // 
            this.btnInputGrade.Location = new System.Drawing.Point(15, 82);
            this.btnInputGrade.Name = "btnInputGrade";
            this.btnInputGrade.Size = new System.Drawing.Size(241, 36);
            this.btnInputGrade.TabIndex = 30;
            this.btnInputGrade.Text = "Input Grade";
            this.btnInputGrade.UseVisualStyleBackColor = true;
            this.btnInputGrade.Click += new System.EventHandler(this.btnInputGrade_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 124);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(241, 146);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.TabStop = false;
            this.txtOutput.Text = "";
            // 
            // frmGradePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 286);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnInputGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGradePoint";
            this.Text = "Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnInputGrade;
        private System.Windows.Forms.RichTextBox txtOutput;
    }
}

