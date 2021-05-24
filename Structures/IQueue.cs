using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    interface IQueue<T>
    {
        public void EnQueue(T value);

        public T DeQueue();
        public bool IsEmpty();
        public T GetFront();
    }
}
