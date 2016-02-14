using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiblarySrtykt
{
    public class MyArrayList<T> : IntList<T>
    {
        int current;
        int Max;
        T[] A;

        public MyArrayList(int N)
        {
            Max = N;
            A = new T[Max];
            current = 0;
        }

        public void Insert(T elem, int ind)
        {
            if (ind < 0)
                throw new Exception("Индекс должен быть положительным числом");

            if (ind >= Max)
                throw new Exception("Индекс больше или равен максимуму");

            if (current < Max)
            {
                for (int i = current; i > ind; i--)
                {
                    A[i] = A[i - 1];
                }
                A[ind] = elem;
                current += 1;
            }
        }

        public void Remove(int ind)
        {
            if (ind < 0)
                throw new Exception("Индекс должен быть положительным числом");

            if (ind >= Max)
                throw new Exception("Индекс больше или равен максимуму");

            if (current != 0)
            {
                for (int i = ind; i < current; i++)
                {
                    A[i] = A[i + 1];
                    current -= 1;
                }
            }
        }

        public T Get(int ind)
        {
            if (ind < 0)
                throw new Exception("Индекс должен быть положительным числом");

            if (ind >= Max)
                throw new Exception("Индекс больше или равен максимуму");

            return A[ind];
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
