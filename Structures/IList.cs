using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    interface IList<T>
    {
        public bool IsEmty();
        public int GetLength();
        public void Insert(int index, T value);
        public void Remove(int index);
        public T Retrive(int index);
        public int Find(T value);
    }
}
