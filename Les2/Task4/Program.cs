namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите x: ");
            double x = Convert.ToInt32(Console.ReadLine());
            double y;

            if (x <= 6 && x >= 4)
            {
                y = x;
                Console.WriteLine("Значение y равно: " + y);
            }
            else if (x > 6)
            {
                y = (3 * x) + (4 * (x * x));
                Console.WriteLine("Значение y равно: " + y);
            }
            else
            {
                Console.WriteLine("Такое значение x не подходит.");
            }
        }
    }
}

