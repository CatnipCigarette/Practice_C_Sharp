using System.Text.RegularExpressions;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            const string alphabet = "*АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            const string numbers = "0123456789";
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();
            var strHash = Hash(Regex.Replace(fullName.ToUpper(), @"[^А-Я]", ""), alphabet);
            do
            {
                strHash = Hash(strHash, numbers);
            } while (strHash.Length > 1);
            Console.WriteLine("Код личности: " + strHash);
            Console.ReadKey();
        }

        static string Hash(string str, string alphabet)
        {
            return str.Select(ch => alphabet.IndexOf(ch))
            .Aggregate(0, (acc, charValue) => acc + charValue)
            .ToString();
        }
    }
}
