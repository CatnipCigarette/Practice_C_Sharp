namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int kol = b - a + 1;

            Console.Write("Вывод чисел: ");
            for (int i = a; i <= b; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Количество чисел равно: " + kol);
            Console.ReadKey();
        }
    }
}