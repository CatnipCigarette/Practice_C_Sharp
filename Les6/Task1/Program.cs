namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.Write("Рандомный массив: ");
            int[] array = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 10);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            var sum = array.Where(e => e % 3 == 0).Sum();
            Console.WriteLine("Сумма чисель кратных 3: " + sum);

        }
    }
}