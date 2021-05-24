using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class ArrayQueue<T> : IQueue<T>
    {

        public const int MAX_CONSTRINT = 100;
        public int MaxCount { get; protected set; }
        private T[] items;
        private int front;
        private int rear;
        private int count;
        public ArrayQueue(int maxCount)
        {
            MaxCount = maxCount;
            items = new T[MaxCount];
            front = 0;
            rear = -1;
            count = 0;
            
        }
        public ArrayQueue() : this(MAX_CONSTRINT) { }
        public void EnQueue(T value)
        {
            if (count > MaxCount)
            {
                throw new StackOverflowException("Queue is full");
            }
            rear = (rear + 1) % MaxCount;
            items[rear] = value;
            count++;

        }

        public T DeQueue()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }
            T value = items[front];
            front = (front + 1) % MaxCount;
            count--;
            return value;
        }

        public T GetFront()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }
            return items[front];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
