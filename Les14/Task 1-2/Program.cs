using System;

namespace Space
{
    class Program
    {
        // методы для подсчета значений функций
        static double F1(double x)
        {
            return x * x;
        }

        static double F2(double x)
        {
            if (x == 0)
                throw new ArgumentException("x не может быть равен нулю");
            return 1 / x;
        }

        static double F3(double x)
        {
            if (x < 0)
                throw new ArgumentException("x не может быть отрицательным");
            return Math.Sqrt(x);
        }

        // создание делегата
        delegate double Function(double x);

        static void Main()
        {
            // создание экземпляра делегата
            Function f = null;
            // присвоение методов делегату
            f += F1;
            f += F2;
            f += F3;

            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            // вызов всех методов через делегат
            foreach (Function func in f.GetInvocationList())
            {
                try
                {
                    double result = func(x);
                    Console.WriteLine("Функция {0}({1}) = {2}", func.Method.Name, x, result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Функция {0}({1}) выдала исключение: {2}", func.Method.Name, x, ex.Message);
                }
            }

            // метод с делегатом в качестве параметра
            void CallFunctions(Function func)
            {
                try
                {
                    double result = func(x);
                    Console.WriteLine("Функция {0}({1}) = {2}", func.Method.Name, x, result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Функция {0}({1}) выдала исключение: {2}", func.Method.Name, x, ex.Message);
                }
            }

            CallFunctions(f);
        }
    }
}