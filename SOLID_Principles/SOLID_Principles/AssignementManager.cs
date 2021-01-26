using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class AssignementManager : IAssignementManager
    {
        public void AssignManager(Employee employee, Employee manager)
        {
            Console.WriteLine($"Manager {manager} is assigned to {employee}");
        }

        public void AssignSubordinate(Employee employee, Employee subordinate)
        {
            Console.WriteLine($"Subordinate {subordinate} is assigned to {employee}");
        }
    }
}
