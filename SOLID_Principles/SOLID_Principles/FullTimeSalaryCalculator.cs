using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class FullTimeSalaryCalculator : ISalaryCalculator
    {
        protected readonly double fullTimeEuroSalary;
        protected readonly double _tax;
        protected readonly double workedHours = 162.4;

        public FullTimeSalaryCalculator(double tax, FullTimeEmployee employee)
        {
            fullTimeEuroSalary = employee.GetSalary();
            _tax = tax;
        }

        public double CalculateSalary()
        {
            return workedHours * fullTimeEuroSalary - (workedHours * fullTimeEuroSalary * _tax / 100);
        }
    }
}
