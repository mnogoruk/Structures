using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class ArrayStack<T> : IStack<T>
    {
        public const int MAX_CONSTRAINT = 100;
        public int MaxCount { get; set; }

        private T[] items;
        private int top;

        public ArrayStack(int maxCount)
        {
            MaxCount = maxCount;
            items = new T[MaxCount];
            top = 0;
        }
        public ArrayStack() : this(MAX_CONSTRAINT) { }
        public T GetTop()
        {
            return items[top-1];
        }

        public bool IsEmpty()
        {
            return top == 0; 
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty");
            }
            T value = GetTop();
            top--;
            return value;
        }

        public void Push(T value)
        {
            if (top > MaxCount)
            {
                throw new StackOverflowException("Stack is full");
            }
            items[top] = value;
            top++;
        }
    }
}
