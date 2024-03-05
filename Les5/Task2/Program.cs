namespace MyNameSpace
{
    class Minus : Exception //создание пользовательского исключения
    {
        public Minus(string message)
            : base(message) { }
    } 

    class Program
    {
        static double F(double x)
        {
            if (x > 0 && x <1)
            {
                return x - 4;
            }
            else if (x > 1)
            {
                return x / ((2 * x) - 2);
            }
            else if (x == 1)
            {
                throw new DivideByZeroException();
            }
            else
            {
                throw new Minus(""); //условие исключения
            }
        }


        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите значение x: ");
                float x = float.Parse((Console.ReadLine()));

                Console.WriteLine("Значение функции: " + Math.Round(F(x), 2));

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0 запрещено!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректное значение!");
            }
            catch (Minus)
            {
                Console.WriteLine("Числа с минусом в диапазон не входят!"); //сообщение исключения
            }
        }
    }
}
