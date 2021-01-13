using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClassPerson person1 = new TestClassPerson() { Age = "aaa", Name = "Valera" };

            object[] attributes = typeof(TestClassPerson).GetCustomAttributes(true);

            var property = person1.GetType().GetProperty("Name");
            string s = property.GetValue(person1, null) as string;

            Console.WriteLine($"{person1} , {s}");


            AttributeValidation a = new AttributeValidation();

            Console.ReadKey();

        }
    }
}
