namespace MySpace
{
    public struct Train : IComparable
    {
        public string destination;
        public int number;
        public DateTime departure;

        public Train(string destination, int number, DateTime departure)//Создание структуры
        {
            this.destination = destination;
            this.number = number;
            this.departure = departure;

        }

        public int CompareTo(object obj)//Сортировка
        {
            Train a = (Train)obj;

            if (this.departure.CompareTo(a.departure) == -1) return -1;
            if (this.departure.CompareTo(a.departure) == 0) return 0;
            else return 1;
        }

        public override string ToString()//Вывод поездов
        {
            return string.Format("Пункт назначения: {0} \nНомер поезда: {1} \nОтправление: {2:t}", destination, number, this.departure);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[2];

            for (int i = 0; i < trains.Length; i++)//Ввод поездов
            {
                Console.WriteLine("Введите название пункта назначения:  ");
                string destination = Console.ReadLine();

                Console.WriteLine("Введите номер поезда: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите время отправления: ");
                DateTime departure = DateTime.Parse(Console.ReadLine());

                trains[i] = new Train(destination, number, departure);
            }

            Console.WriteLine("\nВведите название пункта назначения: ");//Поиск пункта
            string input;
            while ((input = Console.ReadLine()) != " ")
            {
                bool trainFound = false;
                for (int i = 0; i < trains.Length; i++)
                {
                    if (trains[i].destination == input)
                    {
                        Console.WriteLine(trains[i]);
                        trainFound = true;//Пункт найден
                    }
                }

                if (!trainFound)
                    Console.WriteLine("Ничего не найдено. Повторите попытку");//Пункт не найден
            }
        }
    }
}
