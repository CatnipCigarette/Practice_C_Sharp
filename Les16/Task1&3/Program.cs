namespace Space
{
    // Объявляем обобщенный класс MyList, параметризированный типом T
    public class MyList<T>
    {
        private T[] _items;
        private int _count;

        // Конструктор класса
        public MyList()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }

        // Метод для добавления элемента в конец списка
        public void Add(T item)
        {
            // Если массив заполнен, увеличиваем его размер
            if (_count == _items.Length)
            {
                EnsureCapacity(_count + 1);
            }
            // Добавляем элемент в конец списка и увеличиваем количество элементов
            _items[_count++] = item;
        }

        // Индексатор для получения и установки значения элемента по индексу
        public T this[int index]
        {
            get
            {
                // Проверяем, что индекс находится в допустимых границах массива
                if (index < 0 || index >= _count)
                {
                    // выбрасываем исключение, если индекс некорректен
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                // возвращаем элемент с указанным индексом
                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                // устанавливаем элемент с указанным индексом
                _items[index] = value;
            }
        }

        // Свойство только для чтения, возвращающее количество элементов в списке
        public int Count
        {
            get { return _count; }
        }

        // Приватный метод для увеличения ёмкости массива элементов
        private void EnsureCapacity(int minCapacity)
        {
            // Рассчитываем новую ёмкость массива
            int newCapacity = _items.Length == 0 ? 4 : _items.Length * 2;
            if (newCapacity < minCapacity)
            {
                newCapacity = minCapacity;
            }
            // Изменяем размер массива элементов
            Array.Resize(ref _items, newCapacity);
        }
    }

    // создаём расширяющий метод
    static class MyListExtensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] result = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                result[i] = list[i];
            }
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            var myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            Console.WriteLine($"Количество элементов в списке: {myList.Count}");
            Console.WriteLine($"Первый элемент в списке: {myList[0]}");
            myList[2] = 4;
            Console.WriteLine($"Третий элемент в списке: {myList[2]}");

            int[] array = myList.GetArray();
            Console.Write("Элементы массива: ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
