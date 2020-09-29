using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // State of the object can be stored using serialization of objects
            EmpWageBuilderObject SapLabsWageBuilder = new EmpWageBuilderObject("Sap Labs", 200, 20, 100);
            EmpWageBuilderObject DEShawWageBuilder = new EmpWageBuilderObject("DE Shaw", 250, 20, 70);
            SapLabsWageBuilder.CalculateEmpWage();
            DEShawWageBuilder.CalculateEmpWage();
            SapLabsWageBuilder.GetDetails();
            DEShawWageBuilder.GetDetails();
        }
                
    }
}
