using ShapeLib;
using System;
using System.Drawing;

namespace MyNameSpace
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Введите первую сторону: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую сторону: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третью сторону: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            try
            {
                Triangle Tr = new(a, b, c);

                Console.WriteLine("Пириметр: " + Tr.Perimetr());
                Console.WriteLine("Площадь: " + Tr.Square());
                Console.WriteLine("Тип: " + Tr.TriangleType());
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message,ex.StackTrace);
            }

            Console.Write("Введите высоту: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длинну: ");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            try
            {
                Rectanglee Re = new(d, e);
                Console.WriteLine("Пириметр: " + Re.Perimetr());
                Console.WriteLine("Площадь: " + Re.Square());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
        }
    }
}
