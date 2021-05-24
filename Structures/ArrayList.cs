using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class ArrayList<T> : IList<T>
    {
        public const int  MAX_CONSTRAINT = 100;
        public int MaxCount { get; protected set; }
        private T[] nodes;
        private int last;
        public ArrayList(int maxCount)
        {
            this.MaxCount = maxCount;
            nodes = new T[maxCount];
            this.last = 0;
        }
        public ArrayList() : this(MAX_CONSTRAINT) { }
        
        public int Find(T value)
        {
            for (int i = 0; i < last; i++)
            {
                if (nodes[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public int GetLength()
        {
            return last;
        }

        public void Insert(int index, T value)
        {
            if (last >= MaxCount)
            {
                throw new StackOverflowException("List is full");
            }
            if (index > last || index < 0)
            {
                throw new IndexOutOfRangeException("Idex out of range");
            }
            for (int i = last; i >= index; i--)
            {
                nodes[i + 1] = nodes[i];
            }
            last = last + 1;
            nodes[index] = value;
        }

        public bool IsEmty()
        {
            return last == 0;
        }

        public void Remove(int index)
        {
            if (index > last || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            last = last - 1;
            for (int i = index; i <last; i++)
            {
                nodes[i] = nodes[i + 1];
            }
        }

        public T Retrive(int index)
        {
            return nodes[index];
        }
    }
}
