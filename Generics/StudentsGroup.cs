using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class StudentsGroup<Student> : GenericGroup<Person>
    {
        private string groupName;
        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public override void ShowAllPersonsInfo()
        {
            Console.WriteLine("The students from the group :");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        public override int Count()
        {
            return students.Count;
        }
    }
}
