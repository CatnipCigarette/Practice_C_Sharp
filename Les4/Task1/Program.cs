namespace MyNamespace
{
    class Program
    {
        static int F(int x)
        {
            int tmp = x / 10; 
            return tmp % 10;
        }

        static void Main()
        {
            Console.Write("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите c:");
            int c = Convert.ToInt32(Console.ReadLine());

            double z = F(a) + F(b) - F(c);
            Console.WriteLine("z = " + z);
        }
    }
}
