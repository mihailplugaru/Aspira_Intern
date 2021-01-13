using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
        public virtual  void ShowPersonInfo()
        {
            Console.Write("Show person Info :  ");
            Console.WriteLine(ToString());
        }
    }
}
