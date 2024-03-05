using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку с символом #: ");
            string input = Console.ReadLine();

            string result = "";
            foreach (char c in input)
            {
                if (c != '#')
                {
                    result += c;
                }
                else if (result.Length > 0)
                {
                    result = result.Remove(result.Length - 1);
                }
            }

            Console.WriteLine("Преобразованная строка: " + result);
        }
    }
}