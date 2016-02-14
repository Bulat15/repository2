using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста введите первую строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Пожалуйста введите вторую строку: ");
            string str2 = Console.ReadLine();
            Console.WriteLine("Пожалуйста введите третью строку: ");
            string str3 = Console.ReadLine();
            Console.WriteLine("Пожалуйста введите четвертую строку: ");
            string str4 = Console.ReadLine();
            Console.WriteLine("Пожалуйста введите пятую строку: ");
            string str5 = Console.ReadLine();

            string[] s = { str1, str2, str3, str4, str5 };
            StrSort sort1 = new StrSort(MethodStringSort);
            string[] ss = sort1(s);

            foreach (var elem in ss)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();


        }

        public delegate string[] StrSort(string[] str);

        static string[] MethodStringSort(string[] str)
        {
            string[] str2 = str;
            //сортировка строк по длине
            for (int i = 0; i < str2.Length - 1; i++)
            {
                for (int j = i + 1; j < str2.Length; j++)
                {
                    if (str2[j].Length < str2[i].Length)
                    {
                        var temp = str2[i];
                        str2[i] = str2[j];
                        str2[j] = temp;
                    }
                    //поиск одинаковых строк и упорядочивание их по алфавиту
                    if (str2[j].Length == str2[i].Length && str2[j].CompareTo(str2[i]) < 0)
                    {
                        var temp = str2[i];
                        str2[i] = str2[j];
                        str2[j] = temp;
                    }
                }
            }
            return str2;
        }
    }
}
