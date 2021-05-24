using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class List<T> : IList<T>
    {
        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }
        }
        private Node<T> First { get; set; }
        public List()
        {
            First = new Node<T>();
        }
        public int Find(T value)
        {
            Node<T> current = First;

            int index = 0;
            while (!(current.Next is null))
            {
                if (current.Next.Value.Equals(value))
                {
                    return index;
                }
                index++;
                current = current.Next;
            }
            return -1;
        }

        public int GetLength()
        {
            Node<T> current = First;

            int count = 0;
            while (!(current.Next is null))
            {
                count++;
                current = current.Next;
            }
            return count;

        }

        public void Insert(int index, T value)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            Node<T> current = First;
            Node<T> temp = new Node<T>();
            temp.Value = value;

            int i = 0;
            while (!(current is null))
            {
                if (i >= index)
                {
                    temp.Next = current.Next;
                    current.Next = temp;
                    return;
                }
                current = current.Next;
                i++;
            }
            throw new IndexOutOfRangeException("Index out of range");
        }

        public bool IsEmty()
        {
            return First.Next is null;
        }

        public void Remove(int index)
        {
            Node<T> current = First;

            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

           
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            if (current.Next is null)
            {
                throw new IndexOutOfRangeException("Index out of range");

            }

            current.Next = current.Next.Next;
        }

        public T Retrive(int index)
        {
            Node<T> current = First;

            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }


            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            if (current.Next is null)
            {
                throw new IndexOutOfRangeException("Index out of range");

            }
            return current.Next.Value;
        }
    }
}
