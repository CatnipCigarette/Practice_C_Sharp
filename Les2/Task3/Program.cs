namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int A, B, s, i;
            s = 1;
            Console.Write("Введите первое число (1<=A): ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число (B<=10): ");
            B = Convert.ToInt32(Console.ReadLine());
            for (i = A; i <= B; i++)
            {
                s *= i;
            }
            Console.Write("Произведение чисел от " + A + " до " + B + " равно " + s);
            Console.WriteLine();
        }
    }
}
