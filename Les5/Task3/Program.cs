namespace MyNameSpace
{
    class Not5 : Exception //создание пользовательского исключения
    {
        public Not5(string message)
            : base(message) { }
    }

    class Program
    {
        private static int InvertDigits(int k)
        {
            int result = 0;
            while (k != 0)
            {
                result = result * 10 + k % 10;
                k = k / 10;
            }
            return result;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите 5-ти значное число: ");
                int x = Convert.ToInt32((Console.ReadLine()));
                string a = x.ToString();

                if (a.Length == 5)
                {
                    Console.WriteLine("Переворот числа: " + InvertDigits(x));
                }
                else
                {
                    throw new Not5("");
                }
                
            }
            catch (Not5)
            {
                Console.WriteLine("Вы ввели не 5 чисел!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректное значение!");
            }
        }
    }
}
