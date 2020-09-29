using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmpWageBuilderObject
    {
        private string company;
        private int empRatePerHour, numOfWorkingDays, maxWorkingHours;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxWorkingHours)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
            this.totalEmpWage = 0;
        }
        const int IS_ABSENT = 0;
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;

        public void CalculateEmpWage()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Wage Calculation for Employee of " + this.company);
            Console.WriteLine("*****************************************************");
            Random randObj = new Random();
            int empHours = 0, totalWorkingHoursCumulative = 0;

            for (int currentDay = 1; currentDay <= numOfWorkingDays && totalWorkingHoursCumulative <= maxWorkingHours; currentDay++)
            {
                int option = randObj.Next(0, 3);
                switch (option)
                {
                    case IS_ABSENT:
                        empHours = 0;
                        break;
                    case IS_PART_TIME:
                        empHours = 4;
                        break;
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;
                    default:
                        break;
                }
                if (totalWorkingHoursCumulative + empHours > maxWorkingHours)
                    empHours = 0;
                totalWorkingHoursCumulative += empHours;
                Console.WriteLine("Day " + (currentDay) + " Employee Hours " + empHours);
            }
            Console.WriteLine("Total Employee Hours " + totalWorkingHoursCumulative);
            totalEmpWage = totalWorkingHoursCumulative * empRatePerHour;
            Console.WriteLine("Total Employee Wage " + totalEmpWage + "\n\n");
        }

        public void GetDetails()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Total Employee Wage for "+company+" Employee is: " + totalEmpWage);
            Console.WriteLine("***************************************************** \n");
        }
    }
}
