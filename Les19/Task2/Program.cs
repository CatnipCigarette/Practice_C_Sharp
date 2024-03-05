using System;
using System.IO;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Text.txt";

            try
            {
                string content = File.ReadAllText(path);

                Queue<char> nonDigits = new Queue<char>();
                Queue<char> digits = new Queue<char>();

                foreach (char c in content)
                {
                    if (char.IsDigit(c))
                    {
                        digits.Enqueue(c);
                    }
                    else
                    {
                        nonDigits.Enqueue(c);
                    }
                }

                while (nonDigits.Count > 0)
                {
                    Console.Write(nonDigits.Dequeue());
                }

                while (digits.Count > 0)
                {
                    Console.Write(digits.Dequeue());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            Console.WriteLine();
        }
    }
}