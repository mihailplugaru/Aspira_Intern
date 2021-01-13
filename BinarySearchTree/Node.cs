using BinarySearchTree;

namespace BinarySearchTree_DataStructures
{
    public class Node<T> : TreeNode<T>
    {
        public T Value { get; set; }

        public Node<T> LeftNode;

        public Node<T> RightNode;

        public Node<T> ParentNode;

        public Node(T value)
        {
            Value = value;
        }

        public T getValue()
        {
            return Value;
        }

        public TreeNode<T> getLeft()
        {
            return LeftNode;
        }

        public TreeNode<T> getRight()
        {
            return RightNode;
        }

        public TreeNode<T> getParent()
        {
            return ParentNode;
        }
    }
}

