using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiblarySrtykt
{
    public class MyRefStack<T> : IntStack<T>
    {
        private Cell<T> first = null;

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            if (first == null)
                throw new Exception("Стек пуст");

            var cell = first.data;
            first = first.last;
            return cell;

        }

        public void Push(T elem)
        {
            var newCell = new Cell<T>();
            newCell.data = elem;

            if (first == null)
            {
                first = newCell;
                newCell.last = null;
            }
            else
            {
                newCell.last = first;
                first = newCell;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
