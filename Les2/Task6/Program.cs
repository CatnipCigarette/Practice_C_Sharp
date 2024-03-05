namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int num;
            Console.Write("Введите порядковый номер дня недели: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Название дня недели: ");
            switch (num)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
        }
    }
}
