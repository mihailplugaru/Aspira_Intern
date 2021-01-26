using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_NOT
{
    class SalaryCalculator : IEmployeeManagement
    {
        protected readonly double _tax;
        protected readonly double workedHoursFull = 80;
        protected readonly double workedHoursPart = 40;
        public SalaryCalculator(double tax)
        {
            _tax = tax;
        }
        public double CalculateSalary(Employee employee)
        {
            switch (employee.EmploymentCategory.ToLower())
            {
                case "fulltime":
                    return workedHoursFull * employee.SalaryPerHour - (employee.SalaryPerHour * _tax / 100);
                case "parttime":
                    return workedHoursPart * employee.SalaryPerHour - (employee.SalaryPerHour * _tax / 100);
            }
            return default;
        }

        public void AssignManager(Employee employee, Employee manager)
        {
            throw new NotImplementedException();
        }

        public void AssignSubordinate(Employee employee, Employee subordinate)
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
