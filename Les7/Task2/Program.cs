using System.Text;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == "Z") sb.Append("Z" + "z");
                else sb.Append(str[i]);
            }

            Console.WriteLine("Результат: " + sb.ToString());
            Console.ReadLine();
        }
    }
}
