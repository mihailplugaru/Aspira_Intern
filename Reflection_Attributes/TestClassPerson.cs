using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Attributes
{
    public class TestClassPerson
    {
        [AttributeValidation]
        public  string Name { get; set; }
        public string Age { get; set; }

        public override string ToString()
        {
            return $"{Name}  -  {Age}"; 
        }
    }
}
