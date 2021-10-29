using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***********************************************************
 * 
 * Title: Debugging Code
 * 
 * Author: Greg Beaver
 * 
 * Debugged by: Carl Storms
 * 
 * Date: May 24 2019
 * 
 * Program Brief:
 * 
 * Debug the code supply by Greg Beaver so that it will run,
 * and that all the line will output when run.
 *  - highGrade & highName
 *  - lowGrade & lowName
 *  - average
 *  - numOfGrades
 * 
 ***********************************************************/

namespace Assignment_3__Debugging_Code
{

    public partial class frmGradePoint : Form
    {

        string lowName = ""; //Stores name of the lowest grade
        // this was blank in Orginal code
        string highName = ""; //the string variable highName was needed it stores the name of the highest grade

        double lowGrade = 100;
        int highGrade = 0;

        int sumOfGrades = 0;
        int numOfGrades = 0;

        decimal average = -1;
       

        public frmGradePoint()
        {
            InitializeComponent();
        }

        private void clearForm()
        {
            txtGrade.Text = "";
            txtName.Text = "";
            txtName.Focus();
        }
     

        private void btnInputGrade_Click(object sender, EventArgs e)
        {
            //clearForm(); - Orginal code

            //int grade = txtGrade.Text; - Original Code
            int grade; // create int variable called grade
            
            int.TryParse(txtGrade.Text, out grade); // take the grade input and convert to variable grade
         

            if (grade > highGrade) { 
                highGrade = grade;
                highName = txtName.Text; //The string variable highName was missing class variable above under public partial class
            }

            if (grade < lowGrade) {
                lowGrade = grade;
                //lowName = txtName.Text - Orginal Code
                lowName = txtName.Text; // there was a semi-colon missing at the end
            }

            sumOfGrades += grade;
            numOfGrades++;
            average = sumOfGrades / numOfGrades;
           

            //Output should display all of the lines. Highest, Lowest, Running, Count.
            txtOutput.Text = "Highest Grade: " + highGrade + " from " + highName;
            //txtOutput.Text = "\r\nLowest Grade: " + lowGrade  " from " + lowName; - orignal code
            txtOutput.Text += "\r\nLowest Grade: " + lowGrade + " from " + lowName; // this line was missing 2 +'s
            //txtOutput.Text = "\r\nRunning Average: " + average; - Orginal Code
            txtOutput.Text += "\r\nRunning Average: " + average;
            //txtOutput.Text = "\r\nCount of Grades: " + numOfGrades; - Orginal Code
            txtOutput.Text += "\r\nCount of Grades: " + numOfGrades; // this line was missing a +

            clearForm(); //this needed to be moved to the end of the code block, from the beginning of the code block

            //I also made the txtOutput box ReadOnly on the Form
        }
    }
}
