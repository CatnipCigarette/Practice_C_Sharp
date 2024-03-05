using System;
using System.IO;
using System.Linq;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\Учёба\Практика по пр\Les17\Strings.txt"; // путь к файлу

            // a) вывести весь файл на экран
            Console.WriteLine("Содержимое файла:");
            Console.WriteLine(File.ReadAllText(filePath));
            Console.WriteLine();

            // b) подсчитать количество строк
            int linesCount = File.ReadLines(filePath).Count();
            Console.WriteLine("Количество строк в файле: " + linesCount);
            Console.WriteLine();

            // c) подсчитать количество символов в каждой строке
            var linesLength = File.ReadLines(filePath)
                                 .Select(s => s.Length);
            Console.WriteLine("Количество символов в каждой строке:");
            Console.WriteLine(string.Join(" ", linesLength));
            Console.WriteLine();

            // d) удалить последнюю строку из файла, результат записать в новый файл
            string newFilePath = @"E:\Учёба\Практика по пр\Les17\Strings_New.txt"; // путь к новому файлу
            string[] lines = File.ReadAllLines(filePath);
            File.WriteAllLines(newFilePath, lines.Take(lines.Length - 1));
            Console.WriteLine("Последняя строка удалена из файла");
            Console.WriteLine();

            // e) вывести на экран строки с s1 по s2
            int s1 = 2; // начальная строка
            int s2 = 4; // конечная строка
            Console.WriteLine($"Строки с {s1}-й по {s2}-ю:");
            Console.WriteLine(string.Join(Environment.NewLine, lines.Skip(s1 - 1).Take(s2 - s1 + 1)));
            Console.WriteLine();

            // f) найти длину самой длинной строки и вывести ее на экран
            int maxLength = lines.Max(s => s.Length);
            Console.WriteLine("Длина самой длинной строки: " + maxLength);
            Console.WriteLine();

            // g) вывести на экран все строки начинающиеся с заданной буквы
            Console.Write("Введите букву начала строки: ");
            char startChar = Convert.ToChar(Console.ReadLine()); // начальная буква
            Console.WriteLine($"Строки, начинающиеся с буквы '{startChar}':");
            Console.WriteLine(string.Join(Environment.NewLine, lines.Where(s => s.StartsWith(startChar.ToString()))));
            Console.WriteLine();

            // h) переписать его строки в другой файл, порядок строк во втором файле должен быть обратным по отношению к порядку строк в заданном файле.
            string reverseFilePath = @"E:\Учёба\Практика по пр\Les17\Strings_Reverse.txt"; // путь к файлу со строками в обратном порядке
            File.WriteAllLines(reverseFilePath, lines.Reverse());
            Console.WriteLine("Строки записаны в обратном порядке в файл " + reverseFilePath);
        }
    }
}