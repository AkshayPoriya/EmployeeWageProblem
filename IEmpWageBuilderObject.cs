using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    interface IEmpWageBuilderObject
    {
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxWorkingHours);
        public void ComputeEmpWage();
        public int GetTotalWage(string company);
    }
}
