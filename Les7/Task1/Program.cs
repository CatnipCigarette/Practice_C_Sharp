using System.Text.RegularExpressions;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите текст: ");
            string str = Console.ReadLine();

            var result = Regex.Replace(str, @"[аеёиоуыэюя]", "*");
            Console.WriteLine("Результат: " + result);
        }
    }
}