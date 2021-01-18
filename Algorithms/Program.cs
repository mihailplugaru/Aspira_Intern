using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialData = new int[] { 3, 5, 8, 9, 4, 1, 6, 10, 12, 2, 0, 11, 7 };

            LinearSearch(initialData, 5);

            BinarySearch(initialData.OrderBy(x => x).ToArray(), 7, 0, initialData.Length - 1);

            Console.WriteLine("Sorting algorithms :");
            QuickSort(initialData, 0, initialData.Length - 1);
            Console.WriteLine($"\ninitial array after QuickSort : {String.Join(", ", initialData)}");

            BubbleSort(initialData);
            Console.WriteLine($"\ninitial array after BubbleSort : {String.Join(", ", initialData)}");

            Console.ReadKey();

        }

        static void LinearSearch(int[] inputArr, int elementToFind)
        {
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] == elementToFind)
                {
                    Console.WriteLine("Element {0} found at array index {1}", elementToFind, i);
                }
            }
        }

        static void BinarySearch(int[] inputArr, int elementToFind, int min, int max)
        {
            int mid = (min + max) / 2;
            if (elementToFind == inputArr[mid])
            {
                Console.WriteLine("Element {0} found at sorted array index {1}", elementToFind, inputArr[mid++]);
                return;
            }
            if (elementToFind < inputArr[mid])
            {
                BinarySearch(inputArr, elementToFind, min, mid - 1);
            }
            else
            {
                BinarySearch(inputArr, elementToFind, mid + 1, max);
            }
        }

        static public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }

        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                {
                    left++;
                }
                while (numbers[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        public static void BubbleSort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = input.Length - 1; j > i; j--)
                {
                    if (input[j] < input[j - 1])
                    {
                        int x = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = x;
                    }
                }
            }
        }
    }
}
