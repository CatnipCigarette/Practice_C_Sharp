namespace MyNameSpace
{
    class Program
    {
        static double F(double x)
        {
            if (x == -2)
                throw new DivideByZeroException(); //вызов исключения
            return 1 - (5 * x - 7) / (4 * x + 8);
        }

        static double FF(float x)
        {
            if (x == 1)
                throw new DivideByZeroException(); //вызов исключения
            return Math.Pow(Math.Tan(x), 2) + (1 /(x - 1)) ;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите значение x1: ");
                float x1 = float.Parse((Console.ReadLine()));

                Console.WriteLine("Значение функции: " + Math.Round(F(x1), 2));

                Console.Write("Введите значение x2: ");
                float x2 = float.Parse((Console.ReadLine()));

                Console.WriteLine("Значение функции: " + Math.Round(FF(x2), 2));

            }
            catch(DivideByZeroException) //ловим деление на 0
            {
                Console.WriteLine("Деление на 0 запрещено!"); 
            }
            catch (FormatException) //ловим некорректные значения
            {
                Console.WriteLine("Некорректное значение!");
            }
        }
    }
}
