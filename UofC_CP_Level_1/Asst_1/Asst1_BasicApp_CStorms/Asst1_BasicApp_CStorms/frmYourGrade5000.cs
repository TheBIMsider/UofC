using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************
* Title: Your Grade 5000
* 
* Author: Carl Storms
* 
* Date: May 13 2019
* 
* Program Brief:
* 
* Your Grade 5000 will output your name and grade
* in a sentence after the "Run" button is activated
* 
***************************************************/

namespace Asst1_BasicApp_CStorms
{
    public partial class frmYourGrade5000 : Form
    {
        public frmYourGrade5000()
        {
            InitializeComponent();
        }

        private void btnRun_Click_1(object sender, EventArgs e)
        {
            //Making varaiables for storing user inputs in
            string name;
            string grade;

            //Adding user inputs (values) into the varaiables
            name = txtName.Text;
            grade = txtNumberGrade.Text;

            //Output that will be displayed in the "Result" textbox
            txtResult.Text = "Hello " + name + ", you received a grade of " + grade + "% on your test.";
        }
    }
}
