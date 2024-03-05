using System;
using System.Threading;
using System.Threading.Tasks;

namespace Space
{
    class TaskExample
    {
        static void Main()
        {
            int x = 4;

            // Создаем массив из 2 задач
            Task<double>[] tasks = new Task<double>[2];

            // Создаем первую задачу для вычисления z1
            tasks[0] = Task<double>.Factory.StartNew(() =>
            {
                Thread.Sleep(2000); // замедляем выполнение задачи на 2 секунды
                double numerator = Math.Pow(x, 2) + 2 * x - 3 + (x + 1) * Math.Sqrt(Math.Pow(x, 2) - 9);
                double denominator = Math.Pow(x, 2) - 2 * x - 3 + (x - 1) * Math.Sqrt(Math.Pow(x, 2) - 9);
                return numerator / denominator;
            });

            // Создаем вторую задачу для вычисления z2
            tasks[1] = Task<double>.Factory.StartNew(() =>
            {
                Thread.Sleep(3000); // замедляем выполнение задачи на 3 секунды
                return Math.Sqrt((x + 3) / (x - 3));
            });

            // Ожидаем завершения всех задач
            Task.WaitAll(tasks);
            Console.WriteLine("Результаты выполнения всех задач:");
            Console.WriteLine("z1 = " + tasks[0].Result);
            Console.WriteLine("z2 = " + tasks[1].Result);

            // Ожидаем выполнения хотя бы одной задачи
            int index = Task.WaitAny(tasks);
            Console.WriteLine("Хотя бы одна задача выполнена:");
            Console.WriteLine("z" + (index + 1) + " = " + tasks[index].Result);
        }
    }
}