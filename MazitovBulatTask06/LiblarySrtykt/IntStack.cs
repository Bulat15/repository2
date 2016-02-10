using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiblarySrtykt
{
    public interface IntStack<T> : ICloneable, IEnumerable<T>, IDisposable
    {
        void Push(T elem);
        T Pop();
    }
}
