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
    class TimeSheetData
    {
        private decimal sundayHours;
        private decimal mondayHours;
        private decimal tuesdayHours;
        private decimal wednesdayHours;
        private decimal thursdayHours;
        private decimal fridayHours;
        private decimal saturdayHours;

        public decimal SundayHours;
        public decimal MondayHours;
        public decimal TuesdayHours;
        public decimal WednesdayHours;
        public decimal ThursdayHours;
        public decimal FridayHours;
        public decimal SaturdayHours;
        public decimal TotalHours;
        public decimal OvertimeHours;

        public override string ToString()
        {
            return "";
        }

        public TimeSheetData()

        {
            sundayHours = 0;
            mondayHours = 0;
            tuesdayHours = 0;
            wednesdayHours = 0;
            thursdayHours = 0;
            fridayHours = 0;
            saturdayHours = 0;

        }

        public TimeSheetData(decimal monHours, decimal tueHours, decimal wedHours, 
                                                decimal thuHours, decimal friHours)
        {
            sundayHours = 0;
            mondayHours = monHours;
            tuesdayHours = tueHours;
            wednesdayHours = wedHours;
            thursdayHours = thuHours;
            fridayHours = friHours;
            saturdayHours = 0;
        }

        public TimeSheetData(decimal sunHours, decimal monHours, decimal tueHours, decimal wedHours,
                                                decimal thuHours, decimal friHours, decimal satHours)
        {
            sundayHours = sunHours;
            mondayHours = monHours;
            tuesdayHours = tueHours;
            wednesdayHours = wedHours;
            thursdayHours = thuHours;
            fridayHours = friHours;
            saturdayHours = satHours;
        }

        public TimeSheetData(decimal[] array)
        {

        }

    }
}
