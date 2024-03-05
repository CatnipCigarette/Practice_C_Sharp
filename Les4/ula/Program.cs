using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApplication2
{
    class Animal
    {
        private string _name; 
        private int _age;

        public Animal(string name, int age)
        {
            _name = name;
            _age = age;
        }

    }

    class Mammal : Animal
    {
        public Mammal(string name, int age) : base(name, age)
        {
        }
    }

    class Artiodactyl : Animal
    {
        public Artiodactyl(string name, int age) : base(name, age)
        {
        }
    }

    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создадим животное.");
            Console.WriteLine("Выберети из предложенного: ");
            Console.WriteLine("1. Моё животное очень любит молоко!");
            Console.WriteLine("2. Моё животное жить не может без полёта в облаках!");
            Console.WriteLine("3. Если моё животное ударит, то зубов не соберёшь...");
            Console.Write("Ваш ответ: ");
            int ans = Convert.ToInt32(Console.ReadLine());

            switch (ans)
            {
                case 1:
                    Console.WriteLine("Поздравляем у вас Котик!");
                    Console.Write("Выбирите имя: ");
                    string namek = Convert.ToString(Console.ReadLine());
                    Console.Write("Выбирите возраст: ");
                    int agek = Convert.ToInt32(Console.ReadLine());
                    Mammal animal = new Mammal(namek, agek);
                    Console.WriteLine("Объект типа Млекопитающие - создан! ");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Поздравляем у вас Попугайчик!");
                    Console.Write("Выбирите имя: ");
                    string nameb = Convert.ToString(Console.ReadLine());
                    Console.Write("Выбирите возраст: ");
                    int ageb = Convert.ToInt32(Console.ReadLine());
                    Bird animalb = new Bird(nameb, ageb);
                    Console.WriteLine("Объект типа Птица - создан! ");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Поздравляем у вас Лошадка!");
                    Console.Write("Выбирите имя: ");
                    string namea = Convert.ToString(Console.ReadLine());
                    Console.Write("Выбирите возраст: ");
                    int agea = Convert.ToInt32(Console.ReadLine());
                    Artiodactyl animala = new Artiodactyl(namea, agea);
                    Console.WriteLine("Объект типа Парнокопытное - создан! ");
                    Console.WriteLine();
                    break;
            }


        }
    }
}