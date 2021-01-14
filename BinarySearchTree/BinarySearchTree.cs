using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_DataStructures
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {

        private Node<T> _globalRoot;

        public void InsertNode(T value)
        {
            if (_globalRoot == null)
            {
                _globalRoot = new Node<T>(value);
                _globalRoot.ParentNode = null;
            }
            else
            {
                InsertNode(_globalRoot, value, null);
            }
        }

        private static Node<T> InsertNode(Node<T> root, T value, Node<T> parent)
        {
            if (root == null)
            {
                root = new Node<T>(value);
                root.ParentNode = parent;
            }
            else
            {
                if (value.CompareTo(root.Value) <= 0)
                {
                    root.LeftNode = InsertNode(root.LeftNode, value, root);
                }
                else if (value.CompareTo(root.Value) > 0)//Items with the same value are ignored, use >= to insert them into the three
                {
                    root.RightNode = InsertNode(root.RightNode, value, root);
                }
            }
            return root;
        }

        public IEnumerable<T> PreorderTraverseTree()
        {
            if (_globalRoot == null) yield break;

            foreach (var node in PreorderTraverseTree(_globalRoot))
                yield return node;
        }

        private static IEnumerable<T> PreorderTraverseTree(Node<T> root)
        {
            if (root == null) yield break;
            yield return root.Value;
            foreach (var v in PreorderTraverseTree(root.LeftNode))
            {
                yield return v;
            }

            foreach (var v in PreorderTraverseTree(root.RightNode))
            {
                yield return v;
            }
        }

        public IEnumerable<T> InOrderTraverseTree()
        {
            if (_globalRoot == null) yield break;

            foreach (var node in InOrderTraverseTree(_globalRoot))
                yield return node;
        }

        private static IEnumerable<T> InOrderTraverseTree(Node<T> root)
        {
            if (root == null) yield break;
            foreach (var v in InOrderTraverseTree(root.LeftNode))
            {
                yield return v;
            }
            yield return root.Value;
            foreach (var v in InOrderTraverseTree(root.RightNode))
            {
                yield return v;
            }
        }

        public void DeleteNode(T value)
        {
            if (_globalRoot == null) return;
            DeleteNode(ref _globalRoot, value);
        }

        private void DeleteNode(ref Node<T> root, T value)
        {
            if (root == null) return;
            if (root.Value.Equals(value))
                root = Delete(ref root);
            else if (value.CompareTo(root.Value) <= 0)
                DeleteNode(ref root.LeftNode, value);
            else if (value.CompareTo(root.Value) >= 0)
            {
                DeleteNode(ref root.RightNode, value);
            }
        }

        public bool FindNode(T value)
        {
            var res = FindNode(_globalRoot, value);
            if (res == null)
            {
                return false;
            }
            return true;
        }

        private static Node<T> FindNode(Node<T> root, T value)
        {
            Node<T> res = null;
            if (root.LeftNode != null)
                res = FindNode(root.LeftNode, value);

            if (value.CompareTo(root.Value) == 0)
                return root;

            if (res == null && root.RightNode != null)
                res = FindNode(root.RightNode, value);

            return res;
        }

        //public IEnumerable<T> FindRange(T value1, T value2)
        //{
        //    if (_globalRoot == null) yield break;

        //    foreach (var node in FindRange(_globalRoot, value1, value2))
        //        yield return node;
        //}

        //private static IEnumerable<T> FindRange(Node<T> root, T beginR, T endR)
        //{
        //    if (root == null)
        //    {
        //         yield break;
        //    }
        //    if (beginR.CompareTo(root.Value) == -1)
        //    {
        //            FindRange(root.LeftNode, beginR, endR);
        //    }
        //    if (beginR.CompareTo(root.Value) <= 0 && endR.CompareTo(root.Value) >= 0)
        //    {
        //        yield return root.Value;
        //    }
        //    if (endR.CompareTo(root.Value) == 1)
        //    {
        //            FindRange(root.RightNode, beginR, endR);
        //    }
        //}

        public void FindRange(T value1, T value2)
        {
            if (_globalRoot == null) return;
            FindRange(ref _globalRoot, value1, value2);
        }

        private static void FindRange(ref Node<T> root, T beginR, T endR)
        {
            if (root == null)
            {
                return;
            }
            if (beginR.CompareTo(root.Value) == -1)
            {
                FindRange(ref root.LeftNode, beginR, endR);
            }
            if (beginR.CompareTo(root.Value) <= 0 && endR.CompareTo(root.Value) >= 0)
            {
                Console.Write($"{root.Value}  ");
            }
            if (endR.CompareTo(root.Value) == 1)
            {
                FindRange(ref root.RightNode, beginR, endR);
            }
        }

        public Node<T> FindParent(T value)
        {
            var res = FindNode(_globalRoot, value);
            if (res == null)
            {
                return null;
            }
            if (res.ParentNode == null)
            {
                return null;
            }
            return res.ParentNode;
        }

        public Node<T> FindLeft(T value)
        {
            var res = FindNode(_globalRoot, value);
            if (res == null)
            {
                return null;
            }
            if (res.LeftNode == null)
            {
                return null;
            }
            return res.LeftNode;
        }

        public Node<T> FindRight(T value)
        {
            var res = FindNode(_globalRoot, value);
            if (res == null)
            {
                return null;
            }
            if (res.RightNode == null)
            {
                return null;
            }
            return res.RightNode;
        }

        public Node<T> Delete(ref Node<T> root)
        {
            var tempValue = default(T);

            if (_globalRoot == root && root.LeftNode == null && root.RightNode == null)
            {
                //Deletion of root element is allowed  - to forbid it, return root
                return null;
            }
            if (root.LeftNode == null && root.RightNode == null)
            {
                root = null;
            }
            else if (root.LeftNode == null)
            {
                root = root.RightNode;
            }
            else if (root.RightNode == null)
            {
                root = root.LeftNode;
            }
            else
            {
                Replace(ref root, ref tempValue);
                root.Value = tempValue;
            }
            return root;
        }

        private static void Replace(ref Node<T> root, ref T newValue)
        {
            if (root == null) return;
            if (root.LeftNode == null)
            {
                newValue = root.Value;
                root = root.RightNode;
            }
            else
            {
                Replace(ref root.LeftNode, ref newValue);
            }
        }






        //public BinarySearchTree<T> BalancedTree()
        //{
        //    var balanced = new BinarySearchTree<T>();
        //    var inorder = InOrderTraverseTree().ToArray();

        //    balanced._globalRoot = BalanceTree(inorder, 0, inorder.Length - 1);

        //    return balanced;
        //}

        //private static Node<T> BalanceTree(IReadOnlyList<T> inorder, int startIndex, int endIndex)
        //{
        //    if (startIndex > endIndex) return null;

        //    var middIndex = (startIndex + endIndex) / 2;

        //    var root = new Node<T>(inorder[middIndex]);

        //    root.LeftNode = BalanceTree(inorder, startIndex, middIndex - 1);
        //    root.RightNode = BalanceTree(inorder, middIndex + 1, endIndex);

        //    return root;
        //}
    }
}

