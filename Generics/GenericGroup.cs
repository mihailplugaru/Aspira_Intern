using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericGroup<T> where T : Person
    {
        private List<T> people = new List<T>();

        public void AddPerson(T person)
        {
            people.Add(person);
        }

        public virtual void ShowAllPersonsInfo()
        {
            Console.Write("The people from the group : ");
            Console.WriteLine(String.Join(", ", people));
        }

        public virtual int Count()
        {
            return people.Count;
        }
    }
}

