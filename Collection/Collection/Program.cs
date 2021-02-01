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

            col.Add(1);
            col.Add(2);
            col.Add(3);
            Console.WriteLine("\nArray Capacity = " + col.Capacity);
            col.Add(4);
            col.Add(5);
            col.Add(6);
            Console.WriteLine("\nArray Capacity = " + col.Capacity);
            col.Add(7);
            col.Add(8);

            int[] someArray = new int[8] { 9, 9, 9, 9, 9, 9, 9, 9 };

            //                   Add Range
            col.AddRange(someArray);
            Console.WriteLine("\nArray Capacity = " + col.Capacity);
            Console.WriteLine("Array Count = " + col.Count);

            //                   Reverse
            col.Reverse();

            //                   Sort
            //col.Sort();

            //                   Inserting
            //col.Insert(2, 3333333);
            //Console.WriteLine("\nArray Capacity = " + col.Capacity);
            //Console.WriteLine("Array Count = " + col.Count);
            //                   Removing At Index
            //col.RemoveAt(9);
            //Console.WriteLine("\nArray Capacity = " + col.Capacity);
            //Console.WriteLine("Array Count = " + col.Count);

            //                   Removing Item
            //Console.WriteLine("\nItem successfully removed - "+col.Remove(9));
            //Console.WriteLine("\nArray Capacity = " + col.Capacity);
            //Console.WriteLine("Array Count = " + col.Count);

            //                   Index OF
            //Console.WriteLine("\nIndex of item - " + col.IndexOf(1));
            //Console.WriteLine("\nArray Capacity = " + col.Capacity);
            //Console.WriteLine("Array Count = " + col.Count);

            //                   Copy To
            //Console.WriteLine("\nCopying the List to Some Array...");
            //col.CopyTo(someArray, 8);

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
