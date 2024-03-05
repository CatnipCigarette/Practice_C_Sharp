namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int num;
            Console.Write("Введите трёхзначное значное число: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма цифр числа является четным числом: " + ((num / 100 + num / 10 % 10 + num % 10) % 2 == 0));
        }
    }
}
