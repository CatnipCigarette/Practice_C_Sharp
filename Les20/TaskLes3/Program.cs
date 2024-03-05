using System;

namespace XMLSpace
{
    class Program
    {
        /// <summary>
        /// Вычисляет значение функции для заданного аргумента.
        /// </summary>
        /// <param name="x">Аргумент функции.</param>
        /// <param name="y">Выходной параметр, в который будет записан результат.</param>
        /// <returns>Значение функции для заданного аргумента.</returns>
        public static double F(double x, out double y)
        {
            if (x < 0) y = -4;
            else if (x >= 0 && x < 1) y = x * x;
            else y = 2;
            return y;
        }

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = F(x, out y);
            Console.WriteLine("y = " + y);
        }
    }
}

