namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int count = 0;
            int val;
            Console.Write("Введите целое число: ");

            
            if (Int32.TryParse(Console.ReadLine(), out val))
            {
                Console.Write("Делители числа " + val + ": ");
                for (int i = 1; i <= val; i++)
                    if (val % i == 0)
                    {
                        Console.Write(i + " ");
                        count++;
                    }
                Console.WriteLine();
                Console.WriteLine("Количество делителей числа " + val + ": " + count);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Это не число.");
                Console.ReadLine();
            }
        }
    }
}
