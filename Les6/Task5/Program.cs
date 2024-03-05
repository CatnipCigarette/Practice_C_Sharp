namespace MyNamespace
{
    class Program
    {

        public static void Main()
        {
            double F(double n)
            {
                if (n == 1) return 1;

                return n * F(n - 1);
            }

            Console.Write("Введите n: ");
            double n = Convert.ToInt32(Console.ReadLine());

            double f =  F(n - 1) / F(n);
            Console.WriteLine("F(" + n + ") = " + f);
        }
    }
}