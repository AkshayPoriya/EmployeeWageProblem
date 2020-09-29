using System;

namespace EmployeeWageProblem
{
    class Program
    {
        const int IS_ABSENT = 0;
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;

        static void Main(string[] args)
        {
            CalculateEmpWage("Sap Labs", 200, 20, 100);
            CalculateEmpWage("DE Shaw", 250, 20, 70);
        }
        static void CalculateEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxWorkingHours)
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Wage Calculation for Employee of "+company);
            Console.WriteLine("*****************************************************");
            Random randObj = new Random();
            int empHours = 0, totalWorkingHoursCumulative = 0;
            
            for(int currentDay = 1; currentDay <= numOfWorkingDays && totalWorkingHoursCumulative<=maxWorkingHours; currentDay++)
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
                if(totalWorkingHoursCumulative+empHours > maxWorkingHours)
                    empHours = 0;
                totalWorkingHoursCumulative += empHours;
                Console.WriteLine("Day " + (currentDay) + " Employee Hours "+empHours);
            }
            Console.WriteLine("Total Employee Hours "+totalWorkingHoursCumulative);
            int totalEmpWage = totalWorkingHoursCumulative * empRatePerHour;
            Console.WriteLine("Total Employee Wage: "+totalEmpWage + "\n\n");
        }
        
    }
}
