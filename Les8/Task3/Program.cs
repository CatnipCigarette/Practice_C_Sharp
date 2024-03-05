using System.Text.RegularExpressions;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Func<int, int, int> func = (r, c) =>
            {
                return r * c;
            };

            Console.Write("Введите текст: ");
            string str = Console.ReadLine();

            int result = Regex.Matches(str, @"\d+").Cast<Match>()
                .Select(v => Convert.ToInt32(v.Value))
                .Aggregate(func);
            Console.WriteLine("Произведение чисел в тексте: " + result);
            Console.ReadKey(true);
        }
    }
}

//Когда теряет 10 равновесие твоё сознание усталое, когда5 ступеньки этой лест2ницы уходят из-под ног