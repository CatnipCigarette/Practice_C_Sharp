namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int x = 2;
            double y = (Math.Tan(Math.Sqrt(Math.Log(Math.Exp(x + 1), 10)))) - ((3 + Math.Sin(Math.Pow(x, 2))) / (Math.Sin(Math.Pow(x, 2)) - Math.Cos(Math.Pow(x, 2))));
            Console.WriteLine("Значение аргумента x = 2");
            Console.WriteLine("В таком случае значение функции равно " + y);
        }
    }
}