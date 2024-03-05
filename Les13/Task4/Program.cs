using System;

namespace Space
{
    delegate int RandomNumberGenerator();

    class Program
    {
        static void Main(string[] args)
        {
            RandomNumberGenerator[] generators = new RandomNumberGenerator[5];

            // заполним массив генераторами случайных чисел
            for (int i = 0; i < generators.Length; i++)
            {
                generators[i] = delegate ()
                {
                    return new Random().Next(100); // случайное число от 0 до 99
                };
            }

            // анонимный метод, который вычисляет среднее арифметическое
            // результатов вызова методов, связанных с делегатами в массиве
            Func<RandomNumberGenerator[], double> average = delegate (RandomNumberGenerator[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i]();
                }
                return (double)sum / arr.Length;
            };

            Console.Write("Сформированный массив: ");
            for (int i = 0; i < generators.Length; i++)
            {
                Console.Write(generators[i]() + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Среднее арифметическое: " + average(generators));
        }
    }
}
