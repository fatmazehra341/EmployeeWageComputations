using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationStatement
{
    internal class EmployeeWageComputation
    {
        const int IS_PRESENT=1;
        const int IS_ABSENT=2;
        public void DisplyayAttendence()
        {
        Random random = new Random();
            int check = random.Next(1, 3);
            switch(check)
            {
                case IS_PRESENT:
                    Console.WriteLine("Employee is present");
                    break;
                    case IS_ABSENT:
                    Console.WriteLine("Employee is absent");
                    break ;
            }
        }
    }
}
