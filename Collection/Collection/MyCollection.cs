using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Collection
{
    public class MyCollection<T> : IEnumerable, IEnumerator
    {
        private T[] arrayList;

        int position = -1;

        int count = 0;

        public MyCollection()
        {
            arrayList = new T[4];
        }

        public T this[int index]
        {
            get => arrayList[index];
            set => arrayList[index] = value;
        }

        internal int Capacity => arrayList.Length;

        public int Count => count;

        public void Add(T item)
        {
            Add(item, count);
            count++;
        }
        
        public void AddRange(IEnumerable<T> inputCollection)
        {
            foreach(var element in inputCollection) {
                Add(element, count);
                count++;
            }
        }

        private void Add(T item, int position)
        {
            HandleFullCollection();
            arrayList[position] = item;
        }

        public void HandleFullCollection()
        {
            if (count >= arrayList.Length)
            {
                Array.Resize(ref arrayList, arrayList.Length * 2);
            }
        }

        public object Current => arrayList[position];

        public bool MoveNext()
        {
            if (position < count - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Clear()
        {
            arrayList = new T[4];
            count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (arrayList[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (arrayIndex >= 0 && arrayIndex < array.Length)
            {
                int listIndex = 0;
                for (int i = arrayIndex; i < array.Length; i++)
                {
                    if (listIndex < count)
                    {
                        array[i] = arrayList[listIndex++];
                    }
                }
            }
            else
            {
                Console.WriteLine("Index out of array's bounds");
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (arrayList[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (arrayList[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            if (index < count && index >= 0)
            {
                for (int i = index; i < count; i++)
                {
                    Add(arrayList[i + 1], i);
                }
                count--;
                if (count - 1 <= Capacity / 2)
                {
                    Array.Resize(ref arrayList, arrayList.Length / 2);
                }
            }
            else
            {
                Console.WriteLine("******** Deletion failed!  Index is out of Collection's size. ********");
            }
        }

        public void Insert(int index, T item)
        {
            if (index < count && index >= 0)
            {
                for (int i = count; i >= index; i--)
                {
                    Add(arrayList[i - 1], i);
                }
                count++;
                Add(item, index);
            }
            else
            {
                Console.WriteLine("******** Insertion failed!  Index is out of Collection's size. ********");
            }
        }

        public void Reverse()
        {
            for (int i = 0; i < count / 2; i++)
            {
                T tmp = arrayList[i];
                arrayList[i] = arrayList[count - i - 1];
                arrayList[count - i - 1] = tmp;
            }
        }

        public void Sort()
        {
            Array.Sort(arrayList);
        }
    }
}
