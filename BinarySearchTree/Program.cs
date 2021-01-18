using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_DataStructures
{
    class Program
    {                                                                 //                 2
        static void Main(string[] args)                               //             1         4
        {                                                             //                     3    5
            var tree = new BinarySearchTree<int>();                   //                              9
                                                                      //                            6          
            var inputArr = new int[] { 2, 1, 4, 5, 9, 3, 6, 7 };      //                               7

            foreach (var r in inputArr)
            {
                tree.InsertNode(r);
            }

            Console.WriteLine("find parent: ");
            Node<int> parent = tree.FindParent(4);
            if (parent == null)
            {
                Console.WriteLine("Node doesn't have parent");
            }
            else
            {
                Console.WriteLine($"The parent is : {parent.Value}");

            }
            Console.ReadLine();

            Console.WriteLine("find Left child: ");
            Node<int> leftChild = tree.FindLeft(4);
            if (parent == null)
            {
                Console.WriteLine("Node doesn't have parent");
            }
            else
            {
                Console.WriteLine($"The Left child is : {leftChild.Value}");

            }
            Console.ReadLine();

            Console.WriteLine("find Right child: ");
            Node<int> rightChild = tree.FindRight(4);
            if (parent == null)
            {
                Console.WriteLine("Node doesn't have parent");
            }
            else
            {
                Console.WriteLine($"The Right child is : {rightChild.Value}");

            }
            Console.ReadLine();

            var values = tree.PreorderTraverseTree().ToList();
            Console.WriteLine("the trees preorder traversal: ");
            Console.WriteLine(string.Join(",", values));
            Console.ReadLine();


            var vals = tree.InOrderTraverseTree().ToList();
            Console.WriteLine("the trees inorder traversal: ");
            Console.WriteLine(string.Join(",", vals));
            Console.ReadLine();

            Console.WriteLine("find node with value 5: ");
            var exists = tree.FindNode(5);
            Console.WriteLine("5 {0} in the tree.",exists? "exists" : "does not exist");
            Console.ReadLine();

            Console.WriteLine("find range between  3 and 7 : ");
            tree.FindRange(3, 7);
            Console.WriteLine();
            Console.ReadLine();



            Console.WriteLine("Find missing number Task :");
            int[] input = new int[] { 3, 2, 4, 6, 1, 5, 7, 9, 10 };
            Console.WriteLine("The missing number in [{0}] must be {1}", string.Join(", ", input), FindMissingNumberFromArray(input));
            Console.ReadKey();

            Console.WriteLine("\nFind repeating number Task :");
            int[] input2 = new int[] { 3, 2, 4, 6, 1, 5, 7, 9, 10,5};
            Console.WriteLine(" '{0}' {1} a repreating  number in [{2}]", 5, AreThereTwoTheSame(input2, 5) ? "is" : "is not", string.Join(", ", input2));
            Console.ReadKey();

        }

        public static double FindMissingNumberFromArray(int[] input)
        {
            double maxElement = input.Length + 1;
            double totalSum = (maxElement) * ((maxElement + 1) / 2);

            for (int i = 0; i < input.Length; i++)
            {
                totalSum -= input[i];
            }
            return totalSum;
        }

        public static bool AreThereTwoTheSame(int[] input, int x)
        {
            return input.Where(a => a.Equals(x)).Count() > 1;
        }
    }
}
