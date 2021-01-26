using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_NOT
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRegister register = new EmployeeRegister();
            Employee mihai = new Employee("Mihai", 10, "parttime");
            Employee victor = new Employee("Victor", 20, "fulltime");
            register.EnrollPartTime(mihai);
            register.EnrollFullTime(victor);

            SalaryCalculator partTimeSalary = new SalaryCalculator(22.5);
            Console.WriteLine($"\nNet salary for {mihai} will be: {partTimeSalary.CalculateSalary(mihai)}");
            SalaryCalculator fullTimeSalary = new SalaryCalculator(25.0);
            Console.WriteLine($"\nNet salary for {victor} will be: {fullTimeSalary.CalculateSalary(victor)}\n");

            AssignementManager assignator = new AssignementManager();
            assignator.AssignManager(mihai, victor);
            assignator.AssignSubordinate(mihai, victor);
            Console.ReadKey();
        }
    }
}
