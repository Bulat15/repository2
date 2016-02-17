using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива:");
            int N = int.Parse(Console.ReadLine());
            Random r = new Random();
            int[] a;
            a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = r.Next(-50, 50);
            }


            //Прямой метод
            List<TimeSpan> ListWatch1 = new List<TimeSpan>();
            for (int i = 1; i < 15; i++)
            {
                Stopwatch s1 = new Stopwatch();
                s1.Start();
                PryamoyMethod(a);
                s1.Stop();
                ListWatch1.Add(s1.Elapsed);
            }
            ListWatch1.Sort();
            Console.WriteLine("Прямой метод затратил времени на исполнение:\n {0}", ListWatch1[7]);


            //Метод с делегатом
            List<TimeSpan> ListWatch2 = new List<TimeSpan>();
            ArrayCondition method = new ArrayCondition(MethodCondition);
            for (int i = 1; i < 15; i++)
            {
                Stopwatch s2 = new Stopwatch();
                s2.Start();
                MethodOfDelegate(a, method);
                s2.Stop();
                ListWatch2.Add(s2.Elapsed);
            }
            ListWatch2.Sort();
            Console.WriteLine("Метод с условием через делегат затратил времени на исполнение:\n {0}", ListWatch2[7]);


            //Метод с анонимным делегатом
            List<TimeSpan> ListWatch3 = new List<TimeSpan>();

            ArrayCondition PositiveNumberAnon = delegate (int elem)
            {
                if (elem > 0)
                    return true;
                else
                    return false;
            };

            for (int i = 1; i < 15; i++)
            {
                Stopwatch s3 = new Stopwatch();
                s3.Start();
                MethodOfDelegate(a, PositiveNumberAnon);
                s3.Stop();
                ListWatch3.Add(s3.Elapsed);
            }
            ListWatch3.Sort();
            Console.WriteLine("Метод с условием через анонимный делегат затратил времени на исполнение:\n {0}", ListWatch3[7]);


            //Метод с лямбда выражением
            List<TimeSpan> ListWatch4 = new List<TimeSpan>();
            ArrayCondition PositiveNumberLambda = (int elem) => elem > 0 ? true : false;
            for (int i = 1; i < 15; i++)
            {
                Stopwatch s4 = new Stopwatch();
                s4.Start();
                MethodOfDelegate(a, PositiveNumberLambda);
                s4.Stop();
                ListWatch4.Add(s4.Elapsed);
            }
            ListWatch3.Sort();
            Console.WriteLine("Метод с условием через делегат в виде лямбда выражения затратил времени на исполнение:\n {0}", ListWatch4[7]);


            //LINQ
            List<TimeSpan> ListWatch5 = new List<TimeSpan>();
            for (int i = 1; i < 15; i++)
            {
                Stopwatch s5 = new Stopwatch();
                s5.Start();
                GetPositive(a);
                s5.Stop();
                ListWatch5.Add(s5.Elapsed);
            }
            ListWatch5.Sort();
            Console.WriteLine("LINQ-выражение затратил времени на исполнение:\n {0}", ListWatch5[7]);

            Console.ReadKey();
        }

        public static IEnumerable<int> PryamoyMethod(int[] arr)
        {
            List<int> poselem = new List<int>();
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    poselem.Add(arr[i]);
                }
            }
            return poselem;
        }

        public delegate bool ArrayCondition(int elem);

        public static bool MethodCondition(int elem)
        {
            if (elem > 0)
                return true;
            else
                return false;
        }


        public static IEnumerable<int> MethodOfDelegate(int[] arr, ArrayCondition cond)
        {
            List<int> poselem = new List<int>();
            foreach (var elem in arr)
            {
                if (cond(elem))
                {
                    poselem.Add(elem);
                }
            }
            return poselem;
        }

        static List<int> GetPositive(int[] arr)
        {
            var result = from elem in arr
                         where elem > 0
                         select elem;
            return result.ToList<int>();
        }
    }
}
