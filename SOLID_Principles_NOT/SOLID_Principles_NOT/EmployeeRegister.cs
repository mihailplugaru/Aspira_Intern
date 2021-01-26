using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_NOT
{
    class EmployeeRegister : IEmployeeManagement
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

        public void AssignManager(Employee employee, Employee manager)
        {
            throw new NotImplementedException();
        }
        public void AssignSubordinate(Employee employee, Employee subordinate)
        {
            throw new NotImplementedException();
        }
        public double CalculateSalary(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
