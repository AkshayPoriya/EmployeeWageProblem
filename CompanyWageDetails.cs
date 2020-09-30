using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class CompanyWageDetails
    {
        public string company;
        public int empRatePerHour, numOfWorkingDays, maxWorkingHours;
        public int totalEmpWage;
        public List<int> dailyWageList;

        public CompanyWageDetails(string company, int empRatePerHour, int numOfWorkingDays, int maxWorkingHours)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
            this.totalEmpWage = 0;
            dailyWageList = new List<int>();
        }
        
        public void GetDailyWageDetails()
        {
            for(int currentDay = 0; currentDay < dailyWageList.Count; currentDay++)
            {
                Console.WriteLine("Day " + (currentDay+1) + " Employee Hours " + dailyWageList[currentDay]);
            }
            
        }
        public void GetTotalWageDetails()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Total Wage for " + company + " Employee is: " + totalEmpWage);
            Console.WriteLine("***************************************************** \n");
        }
    }
}
