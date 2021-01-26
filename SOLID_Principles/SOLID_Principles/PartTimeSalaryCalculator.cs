using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class PartTimeSalaryCalculator : ISalaryCalculator
    {
        protected readonly double partTimeEuroSalary;
        protected readonly double _tax;
        protected readonly double workedHours = 80;

        public PartTimeSalaryCalculator(double tax, PartTimeEmployee employee)
        {
            partTimeEuroSalary = employee.GetSalary();
            _tax = tax;
        }

        public double CalculateSalary() 
        {
            return workedHours * partTimeEuroSalary - (workedHours * partTimeEuroSalary * _tax / 100);
        }
    }
}
