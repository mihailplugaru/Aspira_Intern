using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDelete
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string s = "wwwaspirasoftwarer";

    //        AddressValidation(ref s);
    //        Console.WriteLine(s);

    //        Console.ReadKey();
    //    }
    //    string AddressValidation(ref string s)
    //    {
    //        s = InsertStringAfter(s, "www", ".");
    //        s = InsertStringAfter(s, "software", "/");
    //        s = InsertStringBefore(s, "software", ".");
    //        return s;
    //    }
    //    string InsertStringAfter(string inString, string keyword, string add)
    //    {
    //        int indexOfFind = inString.IndexOf(keyword);
    //        bool endWithThis = inString.EndsWith(keyword);
    //        if (endWithThis) //in case there is nothing after 'software'
    //        { 
    //            return inString; 
    //        }
    //        else
    //        {
    //            string outString = inString;
    //            if (indexOfFind != -1)
    //            {
    //                outString = inString.Insert(indexOfFind + keyword.Length, add);
    //            }
    //            return outString;
    //        }
    //    }
    //    string InsertStringBefore(string inString, string keyword, string add)
    //    {
    //        int indexOfFind = inString.IndexOf(keyword);
    //        int indexOfadd = inString.LastIndexOf(add);
    //        bool isTheSame = inString[indexOfFind - 1].Equals(inString[indexOfadd]);
    //        if (isTheSame)  //in case there already is a dot before 'software'
    //        {
    //            return inString;
    //        }
    //        else
    //        {
    //            string outString = inString;
    //            if (indexOfFind != -1)
    //            {
    //                outString = inString.Insert(indexOfFind, add);
    //            }
    //            return outString;
    //        }
    //    }
    //}

    class Program
    {
        public static int[] finalArray = new int[10];
        public static int maxLength = 0;

        public static void sumSubsets(
            int[] set, int n, int target)
        {

            int[] x = new int[set.Length];
            int j = set.Length - 1;

            while (n > 0)
            {
                x[j] = n % 2;
                n = n / 2;
                j--;
            }

            int sum = 0;

            for (int i = 0; i < set.Length; i++)
                if (x[i] == 1)
                    sum = sum + set[i];

            int subsetLenth = 0;
            if (sum == target)
            {
                for (int i = 0; i < set.Length; i++)
                {
                    if (x[i] == 1)
                    {
                        subsetLenth++;
                    }
                }
                if (sum == target && subsetLenth > maxLength)
                {
                    int indexLength = 0;
                    for (int i = 0; i < set.Length; i++)
                    {
                        if (x[i] == 1)
                        {
                            finalArray[indexLength] = set[i];
                            indexLength++;
                        }

                    }
                    maxLength = indexLength; ;
                }
            }
        }
        public static void findSubsets(int[] arr, int K)
        {
            int x = (int)Math.Pow(2, arr.Length);

            
            for (int i = 1; i < x; i++)
                sumSubsets(arr, i, K);
        }
        public static void Main(String[] args)
        {
            int[] arr = { 5, 6, -5, 5, 3, -2 , 0};
            int K = 8;

            findSubsets(arr, K);
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(finalArray[i] + " ");
            }
            Console.ReadLine();
        }

    }

}
