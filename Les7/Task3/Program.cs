using System.Drawing;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите предложение: ");
            string str = Console.ReadLine();

            string[] split = str.Split(' ');

            for (int i = 0; i < split.Length-1; i++)
            {
                Console.WriteLine(split[i]);
            }

            Console.ReadKey();
        }
    }
}