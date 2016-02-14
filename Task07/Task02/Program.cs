using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Handler1(Person p, TimeOfCame t)
        {
            if (Greet != null)
            {
                Console.WriteLine("[{0} пришел на работу]\n", p.Name);
                Greet(p, p.TimeCame);
            }
            else
            {
                Console.WriteLine("[{0} пришел на работу]\n", p.Name);
            }
        }
        static void Handler2(Person p)
        {
            if (Part != null)
            {
                Console.WriteLine("[{0} ушел домой]\n", p.Name);
                Part(p);
            }
            else
            {
                Console.WriteLine("[{0} ушел домой]\n", p.Name);
            }
        }
        static void Main(string[] args)
        {
            TimeOfCame t1 = new TimeOfCame { TimeCame = DateTime.Parse("6:00") };
            TimeOfCame t2 = new TimeOfCame { TimeCame = DateTime.Parse("9:00") };
            TimeOfCame t3 = new TimeOfCame { TimeCame = DateTime.Parse("12:00") };
            TimeOfCame t4 = new TimeOfCame { TimeCame = DateTime.Parse("19:00") };

            Person john = new Person { Name = "Egor", TimeCame = t1 };
            Person bill = new Person { Name = "Albina", TimeCame = t2 };
            Person hugo = new Person { Name = "Kirill", TimeCame = t3 };
            Person ivan = new Person { Name = "Bulat", TimeCame = t4 };

            john.Came += Handler1;
            john.MyMethod1();
            bill.Came += Handler1;
            bill.MyMethod1();
            hugo.Came += Handler1;
            hugo.MyMethod1();

            bill.Leave += Handler2;
            bill.MyMethod2();
            ivan.Came += Handler1;
            ivan.MyMethod1();
            hugo.Leave += Handler2;
            hugo.MyMethod2();
            ivan.Leave += Handler2;
            ivan.MyMethod2();
            john.Leave += Handler2;
            john.MyMethod2();

            Console.ReadKey();



        }
        public static MessageCome Greet;
        public static MessageLeave Part;
        public delegate void MessageCome(Person Name, TimeOfCame t);
        public delegate void MessageLeave(Person Name);
        public class Person
        {
            public string Name { get; set; }
            public TimeOfCame TimeCame;

            public void Greeting(Person anotherPerson, TimeOfCame t)
            {
                if (t.TimeCame.Hour < 12)
                {
                    Console.WriteLine("Доброе утро, {0}! - сказал {1}", anotherPerson.Name, Name);
                }
                else if (t.TimeCame.Hour > 17)
                {
                    Console.WriteLine("Добрый вечер, {0}! - сказал {1}", anotherPerson.Name, Name);
                }
                else
                {
                    Console.WriteLine("Добрый день, {0}! - сказал {1}", anotherPerson.Name, Name);
                }
            }

            public void Parting(Person anotherPerson)
            {
                Console.WriteLine("Досвидания, {0}! - сказал {1}", anotherPerson.Name, Name);
            }


            public event MessageCome Came;
            public event MessageLeave Leave;
            protected virtual void OnCame()
            {
                if (Came != null)
                {
                    Came(this, TimeCame);
                }
            }
            protected virtual void OnLeave()
            {
                if (Leave != null)
                {
                    Leave(this);
                }
            }

            public void MyMethod1()
            {
                OnCame();
                MessageCome greet = new MessageCome(this.Greeting);
                Greet += greet;
                MessageLeave part = new MessageLeave(this.Parting);
                Part += part;
            }

            public void MyMethod2()
            {

                MessageCome greet = new MessageCome(this.Greeting);
                Greet -= greet;
                MessageLeave part = new MessageLeave(this.Parting);
                Part -= part;
                OnLeave();
            }

        }
        public class TimeOfCame : EventArgs
        {
            public DateTime TimeCame;
        }

    }

}
