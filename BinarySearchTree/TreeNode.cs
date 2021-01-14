using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_DataStructures
{
    public interface ITreeNode<T>
    {
        T getValue();

        ITreeNode<T> getLeft();

        ITreeNode<T> getRight();

        ITreeNode<T> getParent();
    }
}
