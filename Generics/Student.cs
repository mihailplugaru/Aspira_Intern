using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Student : Person
    {
        List<int> marksList;

        public Student(string name)
        {
            Name = name;
            marksList = new List<int>();
        }

        public void AddMark(int mark)
        {
            marksList.Add(mark);
        }

        public void ShowMarks()
        {
            Console.WriteLine($"Student's marks are : " + String.Join(", ", marksList));
        }
        public override void ShowPersonInfo()
        {
            Console.Write("Show student's Info :  ");
            Console.WriteLine(ToString());
        }

        public void GetAverageMark()
        {
            double average = marksList.Count > 0 ? marksList.Average() : 0.0;
            Console.Write($"Student's average mark is : {average}");
        }

        public override string ToString()
        {
            return $"{Name}" + " - " + String.Join(", ", marksList);
        }
    }
}
