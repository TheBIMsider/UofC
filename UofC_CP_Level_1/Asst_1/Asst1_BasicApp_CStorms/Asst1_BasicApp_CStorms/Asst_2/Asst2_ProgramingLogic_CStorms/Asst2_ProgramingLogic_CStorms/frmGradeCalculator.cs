using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 /*************************************************
  * 
  * Title: Grade Calculator
  * 
  * Author: Carl Storms
  * 
  * Date: May 22 2019
  * 
  * Program Brief:
  * 
  * The Grade Calculator will allow for the input of
  * multiple grades as integers that are between a 
  * value of 0 - 100. When the "Calculate" button is
  * activated the output will show the following:
  *  - High Grade
  *  - Low Grade
  *  - Average Grade - as a float to 1 place
  *
  *************************************************/

namespace Asst2_ProgramingLogic_CStorms
{
    public partial class frmGradeCalculator : Form
    {
        //Class Variables
        int gradeTotal = 0;
        int highGrade = 0;
        int lowGrade = 100;
        int numberOfGrades = 0;

        public frmGradeCalculator()
        {
            InitializeComponent();
        }

        private void btnInputGrades_Click(object sender, EventArgs e)
        {
            //Method variable
            int grade;

            int.TryParse(txtGradeInput.Text, out grade);

                if (grade > 100)
                {
                MessageBox.Show("Grade must be between 0 - 100");
                }

                 if (grade < 0)
                {
                MessageBox.Show("Grade must be between 0 - 100");
                }

            if (grade > highGrade && grade <= 100) //checks if the current grade is higher than the highGrade but equal to or below 100;
                highGrade = grade; // if it is, then it becomes the highGrade;

            if (grade < lowGrade && grade >= 0) //checks if the current grade is lower than the lowGrade but equal to or above 0;
                lowGrade = grade; // if it is, then it becomes the lowGrade;

            if (grade > 0 && grade <= 100) //checks if the grade input is between 0 - 100;
                gradeTotal += grade; //gradeTotal = gradeTotal + grade only if above is true;

            if (grade > 0 && grade <= 100) //checks if the grade input is between 0 - 100;
                numberOfGrades++; //numberOfGrades +1 only if above is true;

            txtGradeInput.Clear();
            txtGradeInput.Focus();
          
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            decimal averageGrade = ((decimal)gradeTotal / numberOfGrades); //change int to decimal
            txtSummaryOutput.Text = "High Grade: " + highGrade;
            txtSummaryOutput.Text += "\r\nLow Grade: " + lowGrade;
            txtSummaryOutput.Text += "\r\nAverage Grade: " + averageGrade.ToString("f1"); //float to 1 place

        }

        private void txtSummaryOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
