using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static PhotoAlbum myPhotos = new PhotoAlbum(8);

        static void Main(string[] args)
        {

            while (myPhotos.MoveNext())
            {
                if (myPhotos.Current == null)
                {
                    Console.WriteLine("Empty slot");
                }
                else
                {
                    Console.WriteLine(myPhotos.Current);
                }
            }
            Console.ReadKey();

            Console.WriteLine("\n\t\t\t\tChange the first and last elements.");
            myPhotos[0] = new Photo("Other Phone");
            myPhotos.Last = new Photo("Known");

            myPhotos.Reset();
            foreach (var photo in myPhotos)
            {
                if (photo == null)
                {
                    Console.WriteLine("Empty slot");
                }
                else
                {
                    Console.WriteLine(photo);
                }
            }
            Console.ReadKey();


            PlayWithArrayList();
            Console.ReadKey();

            PlayWithHashtable();
            Console.ReadKey();
        }

        static void PlayWithArrayList()
        {
            Console.WriteLine("\nPlay with ArrayList");
            ArrayList arrayList = new ArrayList();

            arrayList.Add("First ");
            arrayList.Add("Second ");
            arrayList.Add("Third ");
            arrayList.Add("Fourth ");

            string[] array = new string[7];
            array[4] = "fifth";
            array[5] = "sixth";
            array[6] = "seventh";

            arrayList.CopyTo(array);
            Console.WriteLine("Array after ArrayList was copied :");
            PrintArray(array, ' ');
            Console.ReadKey();

            arrayList.AddRange(array);
            Console.WriteLine("ArrayList after Array was added at the end :");
            PrintList(arrayList);
            Console.ReadKey();
        }

        static void PlayWithHashtable()
        {
            Console.WriteLine("\nPlay with Hashtable");

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "value1");
            hashtable.Add(2, "value2");
            hashtable.Add(3, "value3");
            hashtable.Add(4, "value4");

            ICollection valuesOnly = hashtable.Values;

            Console.WriteLine("\nThe entyre Hashtable: ");
            PrintHashtable(hashtable);
            Console.WriteLine("\nThe values of  the Hashtable: ");
            PrintList(valuesOnly);

            if (!hashtable.ContainsValue("value5"))
            {
                Console.WriteLine("Value5 is not found.");
            }
            Console.ReadKey();

            int[] array = new int[4];

            hashtable.Keys.CopyTo(array, 0);

            Console.WriteLine("\nKeys of the Hashtable: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{ array[i] }" + " ");
            }

            Console.WriteLine("\nThe hash code Hashtable: {0}", hashtable.GetHashCode());
            Console.ReadKey();
        }

        public static void PrintList(IEnumerable myList)
        {
            foreach (var obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }

        public static void PrintArray(String[] myArr, char mySeparator)
        {
            for (int i = 0; i < myArr.Length; i++)
                Console.Write("{0}{1}", mySeparator, myArr[i]);
            Console.WriteLine();
        }
        public static void PrintHashtable(Hashtable myHashtable)
        {
            foreach (DictionaryEntry de in myHashtable)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
        }
    }
}
