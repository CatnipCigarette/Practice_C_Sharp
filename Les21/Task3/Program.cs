using System;
using System.Threading.Tasks;

namespace Space
{
    class TaskExample
    {
        static void Main()
        {
            // Создаем первый объект задачи, который вычисляет результат
            Task<int> task1 = Task<int>.Factory.StartNew(() =>
            {
                int number = 123;
                int firstDigit = number / 100;
                int restOfNumber = number % 100;
                return restOfNumber * 10 + firstDigit;
            });

            // Создаем второй объект задачи, который выводит результат на консоль
            Task task2 = task1.ContinueWith(previousTask =>
            {
                Console.WriteLine("Результат: " + previousTask.Result);
            });

            // Ожидаем завершения второй задачи
            task2.Wait();
        }
    }
}