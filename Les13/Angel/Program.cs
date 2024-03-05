using System;

namespace Angel
{
    // Базовый класс "Поле"
    class Field
    {
        private string name;    // название поля
        private double r;       // вес посеянных семян на единицу площади

        // Конструктор с параметрами
        public Field(string name, double r)
        {
            this.name = name;
            this.r = r;
        }

        // Методы доступа к закрытым полям
        public string GetName()
        {
            return name;
        }

        public double GetR()
        {
            return r;
        }

        // Метод для расчета количества урожая с единицы площади
        public double GetHarvest(double k)
        {
            return k * r;
        }

        // Метод для вывода информации о поле
        public void PrintField()
        {
            Console.WriteLine("Поле: {0}", name);
            Console.WriteLine("Вес посеянных семян на единицу площади: {0}", r);
        }
    }

    // Производный класс "Картофельное поле"
    class PotatoField : Field
    {
        private double S;   // площадь поля

        // Конструктор с параметрами
        public PotatoField(string name, double r, double S) : base(name, r)
        {
            this.S = S;
        }

        // Метод для расчета урожая со всего поля
        public double GetTotalHarvest()
        {
            return GetHarvest(1) * S;
        }

        // Переопределение метода для вывода информации о картофельном поле
        public new void PrintField()
        {
            base.PrintField();
            Console.WriteLine("Площадь поля: {0}", S);
            Console.WriteLine("Урожай со всего поля: {0}", GetTotalHarvest());
        }
    }

    // Тестирующая программа
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта базового типа "Поле"
            Field field1 = new Field("Поле 1", 2.5);
            Console.WriteLine("Информация о базовом поле:");
            field1.PrintField();
            Console.WriteLine("Количество урожая с единицы площади: {0}", field1.GetHarvest(1.2));
            Console.WriteLine();

            // Создание объекта производного типа "Картофельное поле"
            PotatoField potatoField1 = new PotatoField("Картофельное поле 1", 3.0, 5.0);
            Console.WriteLine("Информация о картофельном поле:");
            potatoField1.PrintField();
            Console.WriteLine("Количество урожая с единицы площади: {0}", potatoField1.GetHarvest(1.2));
            Console.WriteLine();

            // Использование метода базового типа на объекте производного типа
            Field field2 = new PotatoField("Картофельное поле 2", 2.0, 3.0);
            Console.WriteLine("Информация о картофельном поле, вызванная методом базового класса:");
            field2.PrintField();
            Console.WriteLine("Количество урожая с единицы площади: {0}", field2.GetHarvest(1.2));
            Console.WriteLine();
        }
    }
}