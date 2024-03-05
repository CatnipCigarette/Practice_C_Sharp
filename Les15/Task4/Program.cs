using System;
using System.Threading;

namespace Space
{
    class Program
    {
        static int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // заданный массив чисел
        static int numThreads = 4; // число потоков для вычисления суммы
        static int[] partialSums = new int[numThreads]; // массив для хранения частичных сумм
        static int totalSum = 0; // переменная для хранения общей суммы

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[numThreads]; // создаем массив потоков
            for (int i = 0; i < numThreads; i++)
            {
                int threadIndex = i; // индекс текущего потока
                threads[i] = new Thread(() => partialSums[threadIndex] = ComputePartialSum(threadIndex)); // создаем новый поток, который будет вычислять частичную сумму
                threads[i].Start(); // запускаем поток
            }

            for (int i = 0; i < numThreads; i++)
            {
                threads[i].Join(); // ждем, пока поток закончит выполнение
                totalSum += partialSums[i]; // добавляем его частичную сумму к общей сумме
            }

            Console.WriteLine("Итого: " + totalSum); // выводим общую сумму в консоль
        }

        static int ComputePartialSum(int threadIndex)
        {
            int startIndex = (array.Length / numThreads) * threadIndex; // индекс первого элемента, обрабатываемого текущим потоком
            int endIndex = (threadIndex == numThreads - 1) ? array.Length : (array.Length / numThreads) * (threadIndex + 1); // индекс последнего элемента, обрабатываемого текущим потоком

            int partialSum = 0; // переменная для хранения частичной суммы
            for (int i = startIndex; i < endIndex; i++)
            {
                partialSum += array[i]; // считаем частичную сумму для текущей части массива
            }

            return partialSum; // возвращаем частичную сумму
        }
    }
}
