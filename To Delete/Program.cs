using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Delete
{
    class Program
    {
        static void Main(string[] args)
        {



            List<string> names = new List<string>();

            names.AddRange(new[] { "ana", "daria" });

            var result = names.OrderBy(x => x.Length).SingleOrDefault();

            Console.WriteLine(result);
            Console.ReadKey();
        }


    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
