using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_NOT
{
    public class Employee
    {
        public string FullName { get; set; }
        public double SalaryPerHour { get; set; }
        public string EmploymentCategory { get; set; }

        public Employee(string name, double salary, string category)
        {
            FullName = name;
            SalaryPerHour = salary;
            EmploymentCategory = category;
        }
        public override string ToString()
        {
            return $"{FullName}";
        }
        public double GetSalary()
        {
            return SalaryPerHour;
        }
    }
}
