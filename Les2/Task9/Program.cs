namespace MyNamespace
{
    class Program
    {
        static double F(double x)
        {
            double y;
            y = Math.Acos(x);
            return y;
        }

        static void Main(string[] args)
        {
            double A = 0.5;
            double B = 1;
            double M = 10;
            double H = (A - B) / M;

            for (double i = B; i >= A; i += H)
            {
                Console.WriteLine("Значение " + F(i) + " на шаге " + i);
            }
            Console.ReadLine();
        }
    }
}
