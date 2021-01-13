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
            var inputArr = new int[] { 2, 1, 4, 4, 9, 3, 6, 7 };      //                               7

            foreach (var r in inputArr)
            {
                tree.InsertNode(r);
            }

            //Console.WriteLine("find parent: ");
            //Node<int> parent = tree.FindParent(4);
            //if (parent == null)
            //{
            //    Console.WriteLine("Node doesn't have parent");
            //}
            //else
            //{
            //    Console.WriteLine($"The parent is : {parent.Value}");

            //}
            //Console.ReadLine();            
            
            //Console.WriteLine("find Left child: ");
            //Node<int> leftChild = tree.FindLeft(4);
            //if (parent == null)
            //{
            //    Console.WriteLine("Node doesn't have parent");
            //}
            //else
            //{
            //    Console.WriteLine($"The Left child is : {leftChild.Value}");

            //}
            //Console.ReadLine();            
           
            //Console.WriteLine("find Right child: ");
            //Node<int> rightChild = tree.FindRight(4);
            //if (parent == null)
            //{
            //    Console.WriteLine("Node doesn't have parent");
            //}
            //else
            //{
            //    Console.WriteLine($"The Right child is : {rightChild.Value}");

            //}
            //Console.ReadLine();

            //var values = tree.PreorderTraverseTree().ToList();
            //Console.WriteLine("the trees preorder traversal: ");
            //Console.WriteLine(string.Join(",", values));
            //Console.ReadLine();


            //var vals = tree.InOrderTraverseTree().ToList();
            //Console.WriteLine("the trees inorder traversal: ");
            //Console.WriteLine(string.Join(",", vals));
            //Console.ReadLine();

            //Console.WriteLine("find node with value 5: ");
            //var exists = tree.FindNode(5);
            //Console.WriteLine($"5 exists in the tree : {exists}");
            //Console.ReadLine();

            Console.WriteLine("find range between  1 and 5 : ");
            tree.FindRange(1, 5);
            Console.ReadLine();



        }
    }
}
