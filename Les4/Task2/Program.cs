namespace MyNamespace
{
    class Program
    {
        static double F(double x)
        {
            double y;
            if (x < 0) y = -4;
            else if (x >= 0 && x < 1) y = x * x;
            else y = 2;
            return y;
        }

        static void Main()
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = F(x);
            Console.WriteLine("y = " + y);
        }
    }
}