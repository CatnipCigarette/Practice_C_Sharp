namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int i;
            for (i = B; i >= A; i--)
                Console.Write(i * i * i + " ");
            Console.ReadKey();
        }
    }
}