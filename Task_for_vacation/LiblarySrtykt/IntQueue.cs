using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiblarySrtykt
{
    public interface IntQueue<T> : ICloneable, IEnumerable<T>, IDisposable
    {
        void Enqueue(T data);
        T Dequeue();
    }
}
