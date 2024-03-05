using System;
using System.Threading;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());

            Thread thread1 = new Thread(() => Method1(A, N));
            thread1.Name = "Поток №1";
            Thread thread2 = new Thread(() => Method1(A, N));
            thread2.Name = "Поток №2";
            Thread thread3 = new Thread(() => Method2(A, N));
            thread3.Name = "Поток №3";

            DateTime startTime = DateTime.Now;

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            DateTime endTime = DateTime.Now;

            TimeSpan duration = endTime - startTime;

            Console.WriteLine("Общее время работы: " + duration.TotalMilliseconds + " миллисекунд");
        }

        private static void Method1(int A, int N)
        {
            int result = 0;

            for (int i = 1; i <= N; i++)
            {
                result += A + i;
            }

            Console.WriteLine("Метод 1 - " + Thread.CurrentThread.Name + " результат: " + result);
        }

        private static void Method2(int A, int N)
        {
            int result = 1;

            for (int i = 1; i <= N; i++)
            {
                result *= A;
            }

            Console.WriteLine("Метод 2 - " + Thread.CurrentThread.Name + " результат: " + result);
        }
    }
}
