using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    interface IStack<T>
    {
        public void Push(T value);
        public T Pop();
        public T GetTop();
        public bool IsEmpty();

    }
}
