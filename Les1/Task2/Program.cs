namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите трёхзначное число: ");
            var text = Console.ReadLine();
            var a = Convert.ToInt32(text);
            var b = 1;
            while (a > 0)
            {
                b *= a % 10;
                a /= 10;
            }

            Console.WriteLine(b);
        }
    }
}