using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Stack<T> : IStack<T>
    {
        private List<T> items;
        private int top;
        public Stack()
        {
            top = 0;
            items = new List<T>();
        }

        public T GetTop()
        {
            return items.Retrive(top -1);
        }

        public bool IsEmpty()
        {
            return items.IsEmty();
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty");
            }
            T value = GetTop();
            items.Remove(top-1);
            top--;

            return value;

        }

        public void Push(T value)
        {
            items.Insert(top, value);
            top++;
        }
    }
}
