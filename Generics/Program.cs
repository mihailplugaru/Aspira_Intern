using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Anatolie");
            Student student2 = new Student("Marinela");
            Student student3 = new Student("Vladimir");

            student1.AddMark(10);
            student1.AddMark(9);
            student1.AddMark(6);
            student2.AddMark(9);
            student2.AddMark(8);
            student3.AddMark(8);
            student3.AddMark(7);

            StudentsGroup<Student> group1 = new StudentsGroup<Student> { GroupName = "Internship" };

            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);

            group1.ShowAllPersonsInfo();
            Console.WriteLine($"Number of students in group : {group1.Count()}");

            student1.ShowPersonInfo();
            student1.ShowMarks();
            student1.GetAverageMark();
            Console.ReadKey();

            Console.WriteLine("\n\nSome generic stuff here");
            GenericGroup<Person> genericGroup = new GenericGroup<Person>();
            Teacher teache1 = new Teacher { Name = "Some Teacher" };
            Teacher teache2 = new Teacher { Name = "Some Other Teacher" };
            teache1.ShowPersonInfo();
            genericGroup.AddPerson(teache1);
            genericGroup.AddPerson(teache2);
            genericGroup.AddPerson(student1);
            genericGroup.ShowAllPersonsInfo();
            Console.WriteLine($"Number of people in group : {genericGroup.Count()}");

            Console.ReadKey();
        }
    }
}
