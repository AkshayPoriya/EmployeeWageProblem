using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = Attendance();
            if(isPresent==0)
                Console.WriteLine("Employee is Absent!");
            else
                Console.WriteLine("Employee is Present!");
            int dailyEmployeeWage = 0, partTimeWage = 0;
            if (isPresent == 1)
            {
                dailyEmployeeWage = DailyEmployeeWage();
                partTimeWage = PartTimeWage();
            }
            Console.WriteLine("Daily Employee Wage : {0}", dailyEmployeeWage);
            Console.WriteLine("Part Time Employee Wage : {0}", partTimeWage);
        }

        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 2);
        }

        static int DailyEmployeeWage()
        {
            int fullDayHour = 8;
            int perHourWage = 20;
            return fullDayHour * perHourWage;
        }

        static int PartTimeWage()
        {
            int partTimeHour = 4;
            int perHourWage = 20;
            return partTimeHour * perHourWage;
        }
    }
}
