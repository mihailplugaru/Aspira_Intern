using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public abstract class Employee
    {
        protected string FullName { get; set; }
        protected double salaryPerHour;

        public Employee(string name, double salary)
        {
            FullName = name;
            salaryPerHour = salary;
        }
        public override string ToString()
        {
            return $"{FullName}";
        }
        public double GetSalary()
        {
            return salaryPerHour;
        }
    }
}
