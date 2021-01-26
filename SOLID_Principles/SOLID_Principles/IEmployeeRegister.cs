using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    interface IEmployeeRegister : IEmployeeManagement
    {
        void EnrollFullTime(Employee employee);
        void EnrollPartTime(Employee employee);
        void Dismiss(Employee employee);
    }
}
