using System;

namespace EmployeeWageProblem
{
    class Program
    {
        const int IS_ABSENT = 0;
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_WORKING_HOURS = 100;

        static void Main(string[] args)
        {
            CalculateEmpWage();
        }
        static void CalculateEmpWage()
        {
            Random randObj = new Random();
            int empHours = 0, totalWorkingHoursCumulative = 0;
            
            for(int currentDay = 1; currentDay <= NUM_OF_WORKING_DAYS; currentDay++)
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
                if(totalWorkingHoursCumulative+empHours > MAX_WORKING_HOURS)
                    empHours = 0;
                totalWorkingHoursCumulative += empHours;
                Console.WriteLine("Day " + (currentDay) + " Employee Hours "+empHours);
            }
            Console.WriteLine("Total Employee Hours "+totalWorkingHoursCumulative);
            int totalEmpWage = totalWorkingHoursCumulative * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage: "+totalEmpWage);
        }
        
    }
}
