using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiblarySrtykt
{
    public interface IntList<T> : ICloneable, IEnumerable<T>, IDisposable
    {
        void Insert(T elem, int ind);
        void Remove(int ind);
        T Get(int ind);
    }
}
