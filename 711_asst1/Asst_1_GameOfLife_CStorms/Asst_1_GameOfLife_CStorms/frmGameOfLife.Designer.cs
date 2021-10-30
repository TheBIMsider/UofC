namespace Asst_1_GameOfLife_CStorms
{
    partial class frmGameOfLife
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameOfLife));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpLastGridLoaction = new System.Windows.Forms.GroupBox();
            this.txtStatusTextBox = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtGenertionsCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnResetAllCells = new System.Windows.Forms.Button();
            this.btnSaveGrid = new System.Windows.Forms.Button();
            this.btnLoadGrid = new System.Windows.Forms.Button();
            this.grpGenerationGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grpLastGridLoaction.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpLastGridLoaction);
            this.groupBox1.Controls.Add(this.btnQuit);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(810, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 770);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Controls";
            // 
            // grpLastGridLoaction
            // 
            this.grpLastGridLoaction.Controls.Add(this.txtStatusTextBox);
            this.grpLastGridLoaction.Location = new System.Drawing.Point(28, 360);
            this.grpLastGridLoaction.Name = "grpLastGridLoaction";
            this.grpLastGridLoaction.Size = new System.Drawing.Size(261, 79);
            this.grpLastGridLoaction.TabIndex = 4;
            this.grpLastGridLoaction.TabStop = false;
            this.grpLastGridLoaction.Text = "Last Grid Location";
            // 
            // txtStatusTextBox
            // 
            this.txtStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatusTextBox.Location = new System.Drawing.Point(9, 35);
            this.txtStatusTextBox.Name = "txtStatusTextBox";
            this.txtStatusTextBox.Size = new System.Drawing.Size(241, 20);
            this.txtStatusTextBox.TabIndex = 3;
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(191, 711);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 35);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtGenertionsCount);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnNext);
            this.groupBox4.Location = new System.Drawing.Point(26, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 81);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Single Step";
            // 
            // txtGenertionsCount
            // 
            this.txtGenertionsCount.Location = new System.Drawing.Point(132, 36);
            this.txtGenertionsCount.Name = "txtGenertionsCount";
            this.txtGenertionsCount.Size = new System.Drawing.Size(50, 20);
            this.txtGenertionsCount.TabIndex = 2;
            this.txtGenertionsCount.Text = "1";
            this.txtGenertionsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGenertionsCount.TextChanged += new System.EventHandler(this.txtGenertionsCount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generations";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(23, 28);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 35);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnResetAllCells);
            this.groupBox3.Controls.Add(this.btnSaveGrid);
            this.groupBox3.Controls.Add(this.btnLoadGrid);
            this.groupBox3.Location = new System.Drawing.Point(26, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 183);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Operations";
            // 
            // btnResetAllCells
            // 
            this.btnResetAllCells.Location = new System.Drawing.Point(23, 129);
            this.btnResetAllCells.Name = "btnResetAllCells";
            this.btnResetAllCells.Size = new System.Drawing.Size(100, 35);
            this.btnResetAllCells.TabIndex = 1;
            this.btnResetAllCells.Text = "Reset All Cells";
            this.btnResetAllCells.UseVisualStyleBackColor = true;
            this.btnResetAllCells.Click += new System.EventHandler(this.btnResetAllCells_Click);
            // 
            // btnSaveGrid
            // 
            this.btnSaveGrid.Location = new System.Drawing.Point(23, 80);
            this.btnSaveGrid.Name = "btnSaveGrid";
            this.btnSaveGrid.Size = new System.Drawing.Size(100, 35);
            this.btnSaveGrid.TabIndex = 1;
            this.btnSaveGrid.Text = "Save Grid";
            this.btnSaveGrid.UseVisualStyleBackColor = true;
            this.btnSaveGrid.Click += new System.EventHandler(this.btnSaveGrid_Click);
            // 
            // btnLoadGrid
            // 
            this.btnLoadGrid.Location = new System.Drawing.Point(23, 30);
            this.btnLoadGrid.Name = "btnLoadGrid";
            this.btnLoadGrid.Size = new System.Drawing.Size(100, 35);
            this.btnLoadGrid.TabIndex = 0;
            this.btnLoadGrid.Text = "Load Grid";
            this.btnLoadGrid.UseVisualStyleBackColor = true;
            this.btnLoadGrid.Click += new System.EventHandler(this.btnLoadGrid_Click);
            // 
            // grpGenerationGroupBox
            // 
            this.grpGenerationGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.grpGenerationGroupBox.Location = new System.Drawing.Point(15, 10);
            this.grpGenerationGroupBox.Name = "grpGenerationGroupBox";
            this.grpGenerationGroupBox.Size = new System.Drawing.Size(770, 770);
            this.grpGenerationGroupBox.TabIndex = 1;
            this.grpGenerationGroupBox.TabStop = false;
            this.grpGenerationGroupBox.Text = "Current Generation ";
            // 
            // frmGameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 796);
            this.Controls.Add(this.grpGenerationGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameOfLife";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGameOfLife_FormClosing);
            this.Load += new System.EventHandler(this.MakeGrid);
            this.groupBox1.ResumeLayout(false);
            this.grpLastGridLoaction.ResumeLayout(false);
            this.grpLastGridLoaction.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpGenerationGroupBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnResetAllCells;
        private System.Windows.Forms.Button btnSaveGrid;
        private System.Windows.Forms.Button btnLoadGrid;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtGenertionsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatusTextBox;
        private System.Windows.Forms.GroupBox grpLastGridLoaction;
    }
}

