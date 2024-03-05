using System;
using System.Threading;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем два потока, каждый из которых будет выполнять метод "CalculateSum"
            Thread thread1 = new Thread(new ThreadStart(CalculateSum));
            thread1.Name = "Поток №1";
            Thread thread2 = new Thread(new ThreadStart(CalculateSum));
            thread2.Name = "Поток №2";

            // запоминаем время начала работы программы
            DateTime startTime = DateTime.Now;

            // запускаем оба потока
            thread1.Start();
            thread2.Start();

            // ожидаем завершения выполнения обоих потоков
            thread1.Join();
            thread2.Join();

            // запоминаем время окончания работы программы
            DateTime endTime = DateTime.Now;

            // вычисляем время, затраченное на выполнение программы
            TimeSpan duration = endTime - startTime;

            Console.WriteLine("Общее время работы: " + duration.TotalMilliseconds + " миллисекунд");
        }

        // объявляем метод "CalculateSum", который будет выполняться в каждом из потоков
        private static void CalculateSum()
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            // выводим на экран информацию о выполненной работе текущего потока
            Console.WriteLine("Поток " + Thread.CurrentThread.Name + " с суммой: " + sum + ", время потрачено: " + Thread.CurrentThread.ManagedThreadId + " миллисекунд");
        }
    }
}
