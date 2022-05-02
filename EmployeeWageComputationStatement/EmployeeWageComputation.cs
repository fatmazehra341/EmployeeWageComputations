using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationStatement
{
    internal class EmployeeWageComputation
    {
        int Employee_Wage_Per_Hour=20;
        int Employee_Working_hours=8;
        public void Full_Day_Salary()
        {
            int total_Salary = Employee_Wage_Per_Hour * Employee_Working_hours;
            Console.WriteLine("One day employee salary:->" +total_Salary);

        }
        
    }
}
