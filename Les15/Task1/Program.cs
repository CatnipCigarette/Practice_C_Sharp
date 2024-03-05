using System;
using System.Threading;

namespace Space
{
    class Program
    {
        // Создаем три объекта класса AutoResetEvent, 
        // каждый из которых будет использоваться для синхронизации потоков
        private static AutoResetEvent autoResetEvent1 = new AutoResetEvent(true);
        private static AutoResetEvent autoResetEvent2 = new AutoResetEvent(false);
        private static AutoResetEvent autoResetEvent3 = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            // Создаем три потока
            Thread thread1 = new Thread(new ThreadStart(PrintNumbers1));
            thread1.Name = "Поток №1";
            thread1.Priority = ThreadPriority.Highest;

            Thread thread2 = new Thread(new ThreadStart(PrintNumbers2));
            thread2.Name = "Поток №2";
            thread2.Priority = ThreadPriority.Normal;

            Thread thread3 = new Thread(new ThreadStart(PrintNumbers3));
            thread3.Name = "Поток №3";
            thread3.Priority = ThreadPriority.Lowest;

            // Запускаем потоки
            thread1.Start();
            thread2.Start();
            thread3.Start();

            // Ждем, пока каждый поток завершится
            thread1.Join();
            thread2.Join();
            thread3.Join();

        }

        private static void PrintNumbers1()
        {
            for (int i = 0; i < 10; i++)
            {
                // Поток 1 ожидает, пока autoResetEvent1 не перейдет в сигнальное состояние
                autoResetEvent1.WaitOne();
                // Когда autoResetEvent1 переходит в сигнальное состояние, поток 1 выводит сообщение в консоль
                Console.WriteLine(Thread.CurrentThread.Name + " - " + i);
                // После того, как поток 1 вывел сообщение, он переводит autoResetEvent2 в сигнальное состояние
                autoResetEvent2.Set();
            }
        }

        private static void PrintNumbers2()
        {
            for (int i = 10; i < 20; i++)
            {
                autoResetEvent2.WaitOne();
                Console.WriteLine(Thread.CurrentThread.Name + " - " + i);
                autoResetEvent3.Set();
            }
        }

        private static void PrintNumbers3()
        {
            for (int i = 20; i < 30; i++)
            {
                autoResetEvent3.WaitOne(); // ждем, пока autoResetEvent3 не будет установлен другим потоком
                Console.WriteLine(Thread.CurrentThread.Name + " - " + i);
                autoResetEvent1.Set(); // устанавливаем autoResetEvent1, чтобы первый поток мог продолжить работу
            }
        }
    }
}