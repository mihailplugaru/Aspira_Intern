using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRegister register = new EmployeeRegister();
            PartTimeEmployee mihai = new PartTimeEmployee("Mihai", 10);
            FullTimeEmployee victor = new FullTimeEmployee("Victor", 20);
            register.EnrollPartTime(mihai);
            register.EnrollFullTime(victor);

            ISalaryCalculator partTimeSalary = new PartTimeSalaryCalculator(22.5, mihai);
            Console.WriteLine($"\nNet salary for {mihai} will be: {partTimeSalary.CalculateSalary()}");
            ISalaryCalculator fullTimeSalary = new FullTimeSalaryCalculator(25.0, victor);
            Console.WriteLine($"\nNet salary for {victor} will be: {fullTimeSalary.CalculateSalary()}\n");

            AssignementManager assignator = new AssignementManager();
            assignator.AssignManager(mihai, victor);
            assignator.AssignSubordinate(mihai, victor);
            Console.ReadKey();
        }
    }
}
