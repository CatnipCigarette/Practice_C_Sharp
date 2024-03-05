namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            double x = -b / (2 * a);
            double y = a * x * x + b * x + c;
            Console.WriteLine("Координаты вершины параболы (x; y) = (" + x + ";" + y + ")");
        }
    }
}