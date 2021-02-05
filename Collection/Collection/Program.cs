using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyCollection<int> col = new MyCollection<int>();
            MyCollection<string> col1 = new MyCollection<string>() { "Z", "b", "123", "Mihail" };
            col1.Sort();



            col.Add(1);
            col.Add(2);
            col.Add(3);
            col.Add(4);
            Console.WriteLine("\nArray Capacity = " + col.Capacity);

            col.Add(5);
            col.Add(6);
            Console.WriteLine("\nArray Capacity = " + col.Capacity);
            //col.Add(7);
            //col.Add(8);

            int[] someArray = new int[6];

            //                   Add Range
            //col.AddRange(someArray);
            //Console.WriteLine("\nArray Capacity = " + col.Capacity);
            //Console.WriteLine("Array Count = " + col.Count);

            //Reverse
            col.Reverse();

            //Sort
            //col.Sort();

            //                   Inserting
            //col.Insert(2, 3333333);
            //Console.WriteLine("\nArray Capacity = " + col.Capacity);
            //Console.WriteLine("Array Count = " + col.Count);
            //                   Removing At Index
            //col.RemoveAt(6);
            //Console.WriteLine("\nArray Capacity = " + col.Capacity);
            //Console.WriteLine("Array Count = " + col.Count);

            //                   Removing Item
            //Console.WriteLine("\nItem successfully removed - " + col.Remove(5));
            //Console.WriteLine("\nArray Capacity = " + col.Capacity);
            //Console.WriteLine("Array Count = " + col.Count);

            //                   Index OF
            //Console.WriteLine("\nIndex of item - " + col.IndexOf(1));
            //Console.WriteLine("\nArray Capacity = " + col.Capacity);
            //Console.WriteLine("Array Count = " + col.Count);

            //                   Copy To
            //Console.WriteLine("\nCopying the List to Some Array...");
            //col.CopyTo(someArray, 3);

            //foreach (var element in someArray)
            //{
            //    Console.Write(" " + element);
            //}
            //Console.WriteLine("\nArray Capacity = " + col.Capacity);
            //Console.WriteLine("Array Count = " + col.Count);

            //col.Clear();


            foreach (var item in col)
            {
                Console.Write(" " + item);
            }
            Console.ReadKey();
        }
    }
}
