using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class EmployeeRegister : IEmployeeRegister
    {
        public void Dismiss(Employee employee)
        {
            Console.WriteLine($"{employee} was dismissed!");        
        }

        public void EnrollFullTime(Employee employee)
        {
            Console.WriteLine($"{employee} was enrolled as a Full Time employee!");
        }

        public void EnrollPartTime(Employee employee)
        {
            Console.WriteLine($"{employee} was enrolled as a Part Time employee!");
        }
    }
}
