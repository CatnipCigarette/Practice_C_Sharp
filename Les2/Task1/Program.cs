namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите сторону квадрата: ");
            double a = Convert.ToInt32(Console.ReadLine());
            double p = 4 * a;
            Console.Write("Периметр квадрата: " + p);
            Console.WriteLine();
        }
    }
}