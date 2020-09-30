using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmpWageBuilderObject : IEmpWageBuilderObject
    {

        private List<CompanyWageDetails> companyWageDetailsList;
        private Dictionary<string, CompanyWageDetails> companyNameToWageMap;
        
        public EmpWageBuilderObject()
        {
            this.companyWageDetailsList = new List<CompanyWageDetails>();
            this.companyNameToWageMap = new Dictionary<string, CompanyWageDetails>();
        }
        
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxWorkingHours)
        {
            CompanyWageDetails cwdObj = new CompanyWageDetails(company, empRatePerHour, numOfWorkingDays, maxWorkingHours);
            companyWageDetailsList.Add(cwdObj);
            companyNameToWageMap.Add(company, cwdObj);
        }

        public void ComputeEmpWage()
        {
            foreach(CompanyWageDetails cwdObj in companyWageDetailsList)
            {
                cwdObj.totalEmpWage = CalculateTotalEmployeeWage(cwdObj);
                cwdObj.GetDailyWageDetails();
                cwdObj.GetTotalWageDetails();
            }
        }

        public int GetTotalWage(string company)
        {
            return companyNameToWageMap[company].totalEmpWage;
        }

        private int CalculateTotalEmployeeWage(CompanyWageDetails cwdObj)
        {
            const int IS_ABSENT = 0;
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Wage Calculation for " + cwdObj.company + " Employee");
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
                cwdObj.dailyWageList.Add(empHours);
            }
            Console.WriteLine("Total Employee Hours " + totalWorkingHoursCumulative);
            return totalWorkingHoursCumulative * cwdObj.empRatePerHour;
        }

    }
}
