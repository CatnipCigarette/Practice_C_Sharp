using System.Text.RegularExpressions;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Все IP-адреса в тексте: ");
            Console.WriteLine(string.Join(" | ", Regex.Matches(input, @"([0-9]{1,3}[\.]){3}[0-9]{1,3}").Cast<Match>().Select(_ => _.Value)));
        }
    }
}

//Не выходи из комнаты 139.232.124.125; считай, что тебя продуло. Что интересней на свете стены и стула?149.151.160.162 Зачем выходить оттуда, куда вернешься вечером таким же, каким ты был, тем более — изувеченным14.155.74.88?