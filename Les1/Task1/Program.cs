namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите первое число: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A + "*" + B + "=" + A*B);
        }
    }
}
