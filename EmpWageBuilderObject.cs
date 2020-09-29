using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmpWageBuilderObject
    {

        private const int MAX_NO_OF_COMPANIES = 10;
        private CompanyWageDetails[] CompanyWageDetailsArray;
        private int currentCompanyIndex = 0;
        
        public EmpWageBuilderObject()
        {
            CompanyWageDetailsArray = new CompanyWageDetails[MAX_NO_OF_COMPANIES];
        }
        
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxWorkingHours)
        {
            CompanyWageDetailsArray[currentCompanyIndex] = new CompanyWageDetails(company, empRatePerHour, numOfWorkingDays, maxWorkingHours);
            currentCompanyIndex++;
        }

        public void ComputeEmpWage()
        {
            for(int i = 0; i < currentCompanyIndex; i++)
            {
                CompanyWageDetailsArray[i].totalEmpWage = CalculateTotalEmployeeWage(CompanyWageDetailsArray[i]);
                CompanyWageDetailsArray[i].GetDetails();
            }
        }

        private int CalculateTotalEmployeeWage(CompanyWageDetails cwdObj)
        {
            const int IS_ABSENT = 0;
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Wage Calculation for Employee of " + cwdObj.company);
            Console.WriteLine("*****************************************************");
            Random randObj = new Random();
            int empHours = 0, totalWorkingHoursCumulative = 0;

            for (int currentDay = 1; currentDay <= cwdObj.numOfWorkingDays && totalWorkingHoursCumulative <= cwdObj.maxWorkingHours; currentDay++)
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
                if (totalWorkingHoursCumulative + empHours > cwdObj.maxWorkingHours)
                    empHours = 0;
                totalWorkingHoursCumulative += empHours;
                Console.WriteLine("Day " + (currentDay) + " Employee Hours " + empHours);
            }
            Console.WriteLine("Total Employee Hours " + totalWorkingHoursCumulative);
            return totalWorkingHoursCumulative * cwdObj.empRatePerHour;
        }

    }
}
