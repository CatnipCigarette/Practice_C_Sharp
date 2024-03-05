using System;

namespace Space
{
    delegate string StringDelegate(string s);

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string str = Convert.ToString(Console.ReadLine());

            StringDelegate stringAction = new StringDelegate(ReverseString);
            string result = stringAction(str);
            Console.WriteLine(result);

            stringAction = new StringDelegate(ToUpperCase);
            result = stringAction(str);
            Console.WriteLine(result);

            stringAction = new StringDelegate(ToLowerCase);
            result = stringAction(str);
            Console.WriteLine(result);
        }

        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string ToUpperCase(string s)
        {
            return s.ToUpper();
        }

        static string ToLowerCase(string s)
        {
            return s.ToLower();
        }
    }
}