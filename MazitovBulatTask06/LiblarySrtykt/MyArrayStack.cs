﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiblarySrtykt
{
    public class MyArrayStack<T> : IntStack<T>
    {
        int current;
        int Max;
        T[] A;

        public MyArrayStack(int N)
        {
            Max = N;
            A = new T[Max];
            current = 0;
        }
        public T Pop()
        {
            current -= 1;
            return A[current];
        }

        public void Push(T elem)
        {
            A[current] = elem;
            current += 1;
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
