﻿namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double z1 = ((x * x + 2 * x - 3) + (x + 1) * Math.Sqrt((x * x) - 9)) / ((x * x - 2 * x - 3) + (x - 1) * Math.Sqrt((x * x) - 9));
            double z2 = Math.Sqrt((x + 3) / (x - 3));
            Console.WriteLine("z1 = " + z1);
            Console.WriteLine("z2 = " + z2);
        }
    }
}