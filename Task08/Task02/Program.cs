using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public static class StringToIntPositive
    {
        public static bool IsPositiveNumber(this string str)
        {
            string[] A = str.Split(new Char[] { '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var elem in A)
            {
                char[] CharArray = elem.ToCharArray();
                foreach (var charElem in CharArray)
                {
                    if (Char.IsDigit(charElem) == false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число на проверку: ");
            var str = Console.ReadLine();
            bool flag = str.IsPositiveNumber();
            if (flag)
            {
                Console.WriteLine("Число является положительным");
            }
            else
            {
                Console.WriteLine("Либо число не положительно, либо введенная строка не является числом");
            }
            Console.ReadLine();
        }
    }
}
