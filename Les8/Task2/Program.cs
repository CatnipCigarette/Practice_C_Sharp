namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            text = text.Replace("о", "оОк");
            Console.Write("Текст с заменами: ");
            Console.WriteLine(text);
        }
    }
}
