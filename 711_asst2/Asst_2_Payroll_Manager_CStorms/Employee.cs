/*****************************************************************************************************************************
*  
*  Author:     Carl G Storms
*              July 2019
*
*  Purpose:    Class Assigment #2 - University of Calgary
*                                   Continuing Education
*                                   ICT 711 - Computer Programming Level 2
*
*  Description:    
*
*                  Expected Behaviour - 
*                             
*****************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asst_2_Payroll_Manager_CStorms
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private decimal hourlyRate;
        private TimeSheetData hoursWorked;

        public string FullName;
        public decimal PayAmount;
        public decimal HoursWorked;
        
        public decimal CalculatePay(decimal regularHours, decimal overtimeRate)
        {
            return 0.0m;
        }

        public override string ToString()
        {
            return "";
        }

        public Employee()

        {
            firstName = "";
            lastName = "";
            hourlyRate = 0; 
            hoursWorked = new TimeSheetData();

        }

        public Employee(string fName, string lName, decimal rate)
        {
            firstName = fName;
            lastName = lName;
            hourlyRate = rate;
            hoursWorked = new TimeSheetData();

        } 

    }
}
