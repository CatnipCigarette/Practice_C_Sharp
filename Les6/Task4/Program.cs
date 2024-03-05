namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите размерность: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Матрица: ");
            int[,] matrix = new int[size, size];
            int prNech = 1;

            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(10);
                    if (matrix[i, j] % 2 != 0) prNech *= matrix[i, j];
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Кратность когоко столбца вас интересует: ");
            int noms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число для проверки кратности суммы на кратность: ");
            int numb = Convert.ToInt32(Console.ReadLine());

            int sum = 1;
            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, noms - 1];
            }

            if (sum % numb == 0)
            {
                Console.WriteLine("Сумма " + noms + "-ого столбца, равная " + sum + " кратна " + numb + ".");
            }
            else
            {
                Console.WriteLine("Сумма " + noms + "-ого столбца, равная " + sum + " не кратна " + numb + ".");
            }
        }
    }
}