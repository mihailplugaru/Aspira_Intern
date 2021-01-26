using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_NOT
{
    class AssignementManager : IEmployeeManagement
    {
        public void AssignManager(Employee employee, Employee manager)
        {
            Console.WriteLine($"Manager {manager} is assigned to {employee}");
        }
        public void AssignSubordinate(Employee employee, Employee subordinate)
        {
            Console.WriteLine($"Subordinate {subordinate} is assigned to {employee}");
        }

        public double CalculateSalary(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Dismiss(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void EnrollFullTime(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void EnrollPartTime(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
