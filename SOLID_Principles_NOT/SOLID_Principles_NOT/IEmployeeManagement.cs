using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_NOT
{
    public interface IEmployeeManagement
    {
        void EnrollFullTime(Employee employee);
        void EnrollPartTime(Employee employee);
        void Dismiss(Employee employee);
        double CalculateSalary(Employee employee);
        void AssignManager(Employee employee, Employee manager);
        void AssignSubordinate(Employee employee, Employee subordinate);
    }
}
