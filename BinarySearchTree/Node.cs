namespace BinarySearchTree_DataStructures
{
    public class Node<T> : ITreeNode<T>
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

        public ITreeNode<T> getLeft()
        {
            return LeftNode;
        }

        public ITreeNode<T> getRight()
        {
            return RightNode;
        }

        public ITreeNode<T> getParent()
        {
            return ParentNode;
        }
    }
}

