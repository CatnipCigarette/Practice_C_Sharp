using System;
using System.Collections.Generic;

namespace Space
{
    // Обобщенный класс MyDictionary<TKey, TValue> представляет собой реализацию словаря, похожую на класс Dictionary<TKey, TValue>.
    public class MyDictionary<TKey, TValue>
    {
        // Класс MyDictionary использует словарь Dictionary<TKey, TValue> для хранения элементов.
        private readonly Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

        // Метод Add добавляет элемент с указанным ключом и значением
        // в словарь.
        public void Add(TKey key, TValue value)
        {
            dictionary.Add(key, value);
        }

        // Индексатор this позволяет получить значение элемента словаря по указанному ключу или задать новое значение для существующего элемента.
        public TValue this[TKey key]
        {
            get { return dictionary[key]; }
            set { dictionary[key] = value; }
        }

        // Свойство Count позволяет получить общее количество элементов в словаре.
        public int Count
        {
            get { return dictionary.Count; }
        }

        // Метод для вывода всех элементов словаря.
        public void PrintAllElements()
        {
            foreach (KeyValuePair<TKey, TValue> pair in dictionary)
            {
                Console.WriteLine("{0} : {1}", pair.Key, pair.Value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем новый экземпляр класса MyDictionary<string, int>.
            var myDictionary = new MyDictionary<string, int>();

            // Добавляем несколько элементов в словарь.
            myDictionary.Add("один", 1);
            myDictionary.Add("два", 2);
            myDictionary.Add("три", 3);

            // Выводим все элементы словаря.
            myDictionary.PrintAllElements();

            // Выводим значение элемента с ключом "два".
            Console.WriteLine(myDictionary["два"]);

            // Задаем новое значение для элемента с ключом "три".
            myDictionary["три"] = 33;

            // Выводим значение элемента с ключом "три".
            Console.WriteLine(myDictionary["три"]);

            // Выводим общее количество элементов в словаре.
            Console.WriteLine(myDictionary.Count);
        }
    }
}
