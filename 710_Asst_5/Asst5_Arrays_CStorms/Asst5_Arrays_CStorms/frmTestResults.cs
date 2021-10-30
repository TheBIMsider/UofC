using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO; //added System.IO
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************
* Title: Test Results
* 
* Author: Carl Storms
* 
* Date: June 17 2019
* 
* Program Brief:
* 
* The test results program will read all the test results from
* a loaded text file. From the loaded results it will display:
*  - The Highest Grade
*  - The lowest Grade
*  - The Average Grade
* This process will make use of arrays, and a Try-Catch Statment
* 
*****************************************************************/

namespace Asst5_Arrays_CStorms
{
    public partial class frmTestResults : Form
    {
        public frmTestResults()
        {
            InitializeComponent();
        }

        int gradeTotal = 0;
        int highGrade = 0;
        int lowGrade = 100;
        int numberOfGrades = 0;

        string[] firstName = new string[1001];
        string[] lastName = new string[1001];
        int[] testGrade = new int[1001];

        private void btnLoadTestResults_Click_1(object sender, EventArgs e)
        {
            //assignment txt file (Grades.txt) has been added into this solution.
            try
            {
                int counter = 0;

                string[] allLines = File.ReadAllLines(@"../../Grades.txt", Encoding.UTF8); //Up two directories to find the file
                string[] field = new string[3]; //txt file has 3 columns

                foreach (string line in allLines) //spliting txt file in single lines
                {
                    if (counter != 0) //making sure the header line is not used or read
                    {
                        field = line.Split(','); //spliting txt file by the , between data in each line

                        firstName[counter] = field[0]; //spliting txt file in 3 columns this the 1st column
                        lastName[counter] = field[1]; //2nd column
                        testGrade[counter] = Convert.ToInt16(field[2]); //converting string to int & 3rd column

                        //output the test results line by line in a more human readable format
                        txtResultsSummary.Text += field[0] + " " + field[1] + " " + "received a grade of = " + field[2] + "\r\n";
                        
                    }

                    counter++;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message); //output message if an exception is caught by the try-catch
            }

        }

        private void btnProcessTestResults_Click(object sender, EventArgs e)
        {
            {
                int grade = 0;
                int counter = 0;

                string[] allLines = File.ReadAllLines(@"../../Grades.txt", Encoding.UTF8);
                string[] field = new string[3];

                foreach (string line in allLines)
                {
                    if (counter != 0)
                    {
                        field = line.Split(',');

                        firstName[counter] = field[0];
                        lastName[counter] = field[1];
                        testGrade[counter] = Convert.ToInt16(field[2]); //change string to int

                        txtLastNumber.Text = field[2]; //reads field[2] one line at a time

                        int.TryParse(txtLastNumber.Text, out grade);

                        if (grade > highGrade) //checks if the current grade is higher than the highGrade;
                            highGrade = grade; // if it is, then it becomes the highGrade;

                        if (grade < lowGrade) //checks if the current grade is lower than the lowGrade;
                            lowGrade = grade; // if it is, then it becomes the lowGrade;

                        gradeTotal += grade; //gradeTotal = gradeTotal + grade to get a grand total of all grades;
                        numberOfGrades++; //numberOfGrades = how mnay grades there are in total;

                    }
                    counter++;

                }                

                decimal averageGrade = ((decimal)gradeTotal / numberOfGrades); //change int to decimal
                txtOutputSummary.Text = "Highest Grade: " + highGrade;
                txtOutputSummary.Text += "\r\nLowest Grade: " + lowGrade;
                txtOutputSummary.Text += "\r\nTest Average Grade: " + averageGrade.ToString("f2"); //float to 2 places

            }
        }
    }
}
