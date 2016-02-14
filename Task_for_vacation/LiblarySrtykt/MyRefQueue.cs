using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiblarySrtykt
{
    public class MyRefQueue<T> : IntQueue<T>
    {
        private Cell<T> last = null;

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public T Dequeue()
        {
            if (last.next == null)
                return last.data;

            var current = last;
            while (current.next.next != null)
            {
                current = current.next;
            }

            var T = current.next.data;
            current.next = null;
            return T;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Enqueue(T data)
        {
            var newCell = new Cell<T>();
            newCell.data = data;

            if (last == null)
            {
                last = newCell;
                last.next = null;
            }
            else
            {
                newCell.next = last;
                last = newCell;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

