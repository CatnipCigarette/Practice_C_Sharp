namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите размерность NxN: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите начало интервала a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конец интервала b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Матрица: ");
            int[,] matrix = new int[size, size];
            int prNech = 1;

            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(a, b+1);
                    if (matrix[i, j] % 2 != 0) prNech *= matrix[i, j];
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Произведение нечётных элеменов матрицы равно: " + prNech);
            Console.WriteLine();

            Console.Write("Произведение какой строки вас интересует: ");
            int noms = Convert.ToInt32(Console.ReadLine());

            int pr = 1;
            for (int i = 0; i < size; i++)
            {
                pr *= matrix[noms - 1, i];
            }

            Console.WriteLine("Произведение элементов " + noms + "-ой строки равно: " + pr);

        }
    }
}
