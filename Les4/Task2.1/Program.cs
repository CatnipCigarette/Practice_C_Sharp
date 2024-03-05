namespace MyNamespace
{
    class Program
    {
        static double F(double x, out double y)
        {
            if (x < 0) y = -4;
            else if (x >= 0 && x < 1) y = x * x;
            else y = 2;
            return y;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = F(x, out y);
            Console.WriteLine("y = " + y);
        }
    }
}