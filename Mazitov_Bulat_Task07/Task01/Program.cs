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
            int N = 1;
            bool flag = false;
            Console.WriteLine("Введите число: ");
            while (flag == false)
            {
                string str = Console.ReadLine();
                if (!int.TryParse(str, out N))
                {
                    Console.WriteLine("Введите число!");
                }
                else
                {
                    N = int.Parse(str);
                    flag = true;
                }
            }

            Queue<int> people = new Queue<int>();
            for (int i = 1; i <= N; i++)
            {
                people.Enqueue(i);
            }
            int c = 1;
            while (people.Count > 1)
            {
                if (c % 2 == 1)
                {
                    int temp = people.Dequeue();
                    people.Enqueue(temp);
                    c += 1;
                }
                else
                {
                    people.Dequeue();
                    c += 1;
                }
            }
            int answer = people.Dequeue();
            Console.WriteLine(String.Format("Последний осташийся элемент под номером: {0}", answer));
            Console.ReadKey();
        }
    }
}
