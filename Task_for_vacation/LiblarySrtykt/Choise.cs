using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiblarySrtykt
{
    public enum LiblaryType
    {
        Array,
        References
    }

    public static class Choise
    {
        public static IntList<T> CreateAList<T>(LiblaryType collectionType, int arraySize)
        {
            switch (collectionType)
            {
                case LiblaryType.Array:
                    return new MyArrayList<T>(arraySize);
                case LiblaryType.References:
                    return new MyRefList<T>();
            }
            return null;
        }

        public static IntQueue<T> CreateAQueue<T>(LiblaryType collectionType, int arraySize)
        {
            switch (collectionType)
            {
                case LiblaryType.Array:
                    return new MyArrayQueue<T>(arraySize);
                case LiblaryType.References:
                    return new MyRefQueue<T>();
            }
            return null;
        }

        public static IntStack<T> CreateAStack<T>(LiblaryType LiblaryType, int arraySize)
        {
            switch (LiblaryType)
            {
                case LiblaryType.Array:
                    return new MyArrayStack<T>(arraySize);
                case LiblaryType.References:
                    return new MyRefStack<T>();
            }
            return null;
        }
    }
}
