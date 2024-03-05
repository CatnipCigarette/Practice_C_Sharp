using System;

namespace Space
{
    delegate double CalcFigure(double r); // объявление делегата

    class Program
    {
        static void Main()
        {
            double radius = 5.0;

            CalcFigure cf = new CalcFigure(Calculation.Get_Length);
            Console.WriteLine("Длина окружности = {0}", Math.Round(cf(radius), 2));

            cf = Calculation.Get_Area;
            Console.WriteLine("Площадь круга = {0}", Math.Round(cf(radius), 2));

            cf = Calculation.Get_Volume;
            Console.WriteLine("Объем шара = {0}", Math.Round(cf(radius), 2));

            Console.ReadKey();
        }
    }

    class Calculation
    {
        public static double Get_Length(double r) // метод для вычисления длины окружности
        {
            return 2 * Math.PI * r;
        }

        public static double Get_Area(double r) // метод для вычисления площади круга
        {
            return Math.PI * r * r;
        }

        public static double Get_Volume(double r) // метод для вычисления объема шара
        {
            return 4.0 / 3.0 * Math.PI * r * r * r;
        }
    }
}