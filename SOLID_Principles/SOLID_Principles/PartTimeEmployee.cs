using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name, double salary)
            : base(name, salary)
        {
        }
    }
}
