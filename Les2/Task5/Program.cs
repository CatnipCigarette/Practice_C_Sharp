namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите трёхзначное число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Цифры одинаковые: " + (x % 111 == 0));
            Console.WriteLine();
        }
    }
}