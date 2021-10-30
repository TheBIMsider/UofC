using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Title: Pay Calculator
* 
* Author: Carl Storms
* 
* Date: June 6 2019
* 
* Program Brief:
* 
* The Pay Calculator will output the biweekly pay amount for 
* an employee after their hourly rate and the number
* of weekly hours they worked have been input. It will also 
* give a summary of the biweekly pay for all the employees who
* have had their info entered for that pay period. The Pay 
* Calculator will also validate that all required inputs
* have been entered, are in the correct format, and are 
* positive in value.
* 
***************************************************************/

namespace Asst4_MethodsValidation_CStorms
{
    public partial class frmPayCalculator : Form
    {
        string[] employee = new string[100];
        decimal[] hours = new decimal[100];
        decimal[] rate = new decimal[100];

        int counter = 0;

        public frmPayCalculator()
        {
            InitializeComponent();
        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            IsRequired(txtEmployeeName,"Employee Name"); // validates that the Employee name textbox is not empyt by calling "IsRequired" method
        }

        private void txtHoursPerWeek_TextChanged(object sender, EventArgs e)
        {
            IsRequired(txtHoursPerWeek, "Hours worked"); // validates that the hours per week textbox is not empyt by calling "IsRequired" method
            IsDecimal(txtHoursPerWeek, "Hours worked per week"); // validates that the hours worked input is a decimal by calling "IsDecimal" method
            IsPositive(txtHoursPerWeek, "Hours worked per week"); // validates that the hours worked input is positive by calling "IsPositive" method
        }

        private void txtHourlyRate_TextChanged(object sender, EventArgs e)
        {
            IsRequired(txtHourlyRate, "Hourly rate"); // validates that the hourly rate textbox is not empyt by calling "IsRequired" method
            IsDecimal(txtHourlyRate, "Hourly rate"); // validates that the hourly rate input is a decimal by calling "IsDecimal" method
            IsPositive(txtHourlyRate, "Hourly rate"); // validates that the hourly rate input is positive by calling "IsPositive" method
        }

        private void btnCalculatePay_Click(object sender, EventArgs e)
        {
            decimal hoursWorked;
            decimal payRate;

            decimal.TryParse(txtHoursPerWeek.Text, out hoursWorked);
            decimal.TryParse(txtHourlyRate.Text, out payRate);

            decimal payAmount = (((decimal)hoursWorked * 2) * payRate); // Calculates the total biweekly pay for each set of inputs
            txtPayOutput.Text = payAmount.ToString("c"); // outputs the total biweekly pay as a currency

            try // try & catch block to catch and exceptions
            {
                employee[counter] = txtEmployeeName.Text;
                hours[counter] = Convert.ToDecimal(txtHoursPerWeek.Text);
                rate[counter] = Convert.ToDecimal(txtHourlyRate.Text);

                counter++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input Error!");
            }
 
        }

        private void txtPayOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPaySummary_Click(object sender, EventArgs e)
        {
  
            for (int i=0;i<counter;i++)
            
            {   // the below line of code calculates the biweekly pay of each employee and converts it to currecey, the starts a new line for each employee
                txtSummaryOutput.Text += employee[i] + "'s biweekly paid was " + (rate[i] * (hours[i] * 2)).ToString("c") + " for " + (hours[i] * 2) + " hours of work. \r\n"; 
            }
        }

        private void txtSummaryOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsRequired(TextBox txtbox, string name) // Method to validate that input is required, (textbox is not empty)
        {
            if (txtbox.Text.Trim() == "")
            {
                MessageBox.Show(name + " is a required field");
                txtbox.Focus();
                return false;
            }

            return true;
        }

        private bool IsDecimal(TextBox txtbox, string name) // Method to validate that input is a decimal
        {
            decimal number = 0m;

            if (!decimal.TryParse(txtbox.Text, out number))
            {
                MessageBox.Show(name + " not in decimal format. Please use a decimal number.");
                return false;
            }

            return true;
        }

        private bool IsPositive(TextBox txtbox, string name) // Method to validate that input is positive 
        {
            decimal positive = 0m;

            if (decimal.TryParse(txtbox.Text, out positive))
            {
                
                if (positive < 0)
                {
                    MessageBox.Show(name + " must be a positive number");
                    return false;
                }

            }

            return true;
        }

    }
}
