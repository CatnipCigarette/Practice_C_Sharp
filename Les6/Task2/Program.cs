namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {

            Console.Write("Последовательность a: ");
            int[] arrayA = new int[25];
            Random rnd = new Random();

            for (int i = 0; i < 25; i++)
            {
                arrayA[i] = rnd.Next(-10, 10);
                Console.Write($"{arrayA[i]} ");
            }
            Console.WriteLine();

            Console.Write("Последовательность b: ");
            int[] arrayB = new int[25];

            for (int i = 0; i < 25; i++)
            {
                arrayB[i] = rnd.Next(-10, 10);
                Console.Write($"{arrayB[i]} ");
            }
            Console.WriteLine();

            Console.Write("Изменённая последовательность b: ");
            int[] arrayBA = new int[25]; 

            for (int i = 0; i < 25; i++)
            {
                if (arrayA[i] <= 0)
                {
                    arrayBA[i] = arrayB[i] * 10;
                }
                else
                {
                    arrayBA[i] = 0;
                }
                Console.Write($"{arrayBA[i]} ");
            }
            Console.WriteLine();
        }
    }
}