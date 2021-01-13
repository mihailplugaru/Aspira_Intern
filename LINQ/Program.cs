using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            // DaysOfWeekSubtask();

            //AreThereAnyNumbersSubtask1();

            //CompareTwoArrays();

            PeoplePetsSubtask();
        }


        public static void DaysOfWeekSubtask()
        {
            List<DayOfWeek> daysOfWeek = new List<DayOfWeek>
            { DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday,
            DayOfWeek.Saturday,
            DayOfWeek.Sunday};

            var orderedDays = daysOfWeek.OrderByDescending(day => day.ToString().Length);

            foreach (var day in orderedDays)
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void AreThereAnyNumbersSubtask1()
        {
            int[] a = { 2, -5, 5, 28, -46, 1, 68, 9, 28, 6 };

            var greaterNumbers = from number in a
                                 where number > 10 && number % 2 == 0
                                 select number;

            var myCondition = greaterNumbers.All(number => number % 2 == 0);

            Console.WriteLine("{0} numbers greater than 10 are even.", myCondition ? "All" : "Not all");
            Console.ReadKey();
        }

        public static void AreThereAnyNumbersSubtask2()
        {
            int[] a = { 2, -5, 5, 28, -46, 1, 68, 9, 28, 6 };

            var myCondition = (a.Where(m => m > 10).All(x => (a.Where(n => n % 2 == 0)).Any(y => y == x)));

            Console.WriteLine("{0} numbers greater than 10 are even.", myCondition ? "All" : "Not all");
            Console.ReadKey();
        }

        public static void CompareTwoArrays()
        {
            int[] b = { 4, 2, 5, 6, 9, 30, 1, 33, 7 };
            int[] c = { 3, 6, 31, 3, 66, 9, 7, 21 };

            Console.WriteLine("Common elements :");

            var commonElements = b.Intersect(c);

            foreach (var el in commonElements)
            {
                Console.Write($"{el} ");
            }
            Console.ReadKey();


            Console.WriteLine("\nElements that are in array b but not in array c :");

            var elementsInBOnly = b.Except(c);

            foreach (var el in elementsInBOnly)
            {
                Console.Write($"{el} ");
            }
            Console.ReadKey();

            Console.WriteLine("\nThe distinct elements from both arrays :");

            //var distinctElements = b.Except(c).Concat(c.Except(b));
            var distinctElements = b.Concat(c).Except(b.Intersect(c));

            foreach (var el in distinctElements)
            {
                Console.Write($"{el} ");
            }
            Console.ReadKey();
        }

        public static void PeoplePetsSubtask()
        {
            Pet barley = new Pet { Name = "Barley", Type = "Dog" };
            Pet boots = new Pet { Name = "Boots", Type = "Dog" };
            Pet whiskers = new Pet { Name = "Whiskers", Type = "Cat" };
            Pet daisy = new Pet { Name = "Daisy", Type = "Dog" };
            Pet barleydog = new Pet { Name = "Barleydog", Type = "Dog" };
            Pet bootscat = new Pet { Name = "Bootscat", Type = "Cat" };
            Pet whiskerscat = new Pet { Name = "Whiskerscat", Type = "Cat" };
            Pet daisydog = new Pet { Name = "Daisydog", Type = "Dog" };
            Pet daisycat = new Pet { Name = "Daisycat", Type = "Dog" };

            Person magnus = new Person { Name = "Magnus", Pets = new List<Pet> { barley, barleydog, bootscat } };
            Person terry = new Person { Name = "Adam", Pets = new List<Pet> { boots, whiskers, daisy } };
            Person charlotte = new Person { Name = "Charlotte", Pets = new List<Pet> { daisycat, daisydog } };
            Person zack = new Person { Name = "Zack", Pets = new List<Pet> { whiskerscat } };

            List<Person> peoplePetsList = new List<Person> { magnus, terry, charlotte, zack };

            var query = peoplePetsList
                .OrderByDescending(x => x.Pets.Count)
                .Select(x => new
                {
                    Key = x.Name,
                    pets = x.Pets.OrderBy(y => y.Name).GroupBy(y => y.Type)
                });

            Console.WriteLine("\nOwners and their pets (pets are grouped by type and ordered by name) ");
            foreach (var owner in query)
            {
                Console.WriteLine($"\n{owner.Key} :");
                foreach (var type in owner.pets)
                {
                    Console.WriteLine($"         {type.Key} ({type.Count()}) :");
                    foreach (var pet in type)
                    {
                        Console.WriteLine($"                    - {pet.Name}");
                    }
                }
            }

            Console.ReadKey();
        }

        class Person
        {
            public string Name { get; set; }
            public List<Pet> Pets { get; set; }
        }
        class Pet
        {
            public string Name { get; set; }
            public string Type { get; set; }
        }

    }
}
//var query = peoplePetsList.GroupBy(
//    pet => Math.Floor(pet.Age),
//    pet => pet.Age,
//    (baseAge, ages) => new
//    {
//        Key = baseAge,
//        Count = ages.Count(),
//        Min = ages.Min(),
//        Max = ages.Max()
//    });

//foreach (var result in query)
//{
//    Console.WriteLine("\nAge group : " + result.Key);
//    Console.WriteLine("Nr of Pets in group : " + result.Count());
//    Console.WriteLine("Min age : " + result.Min());
//    Console.WriteLine("Max age : " + result.Max());
//}
