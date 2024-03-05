using System;

namespace Space
{
    public class Task
    {
        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public Task()
        {
            _number = 0;
        }

        public Task(int number)
        {
            _number = number;
        }

        public int MultiplyDigits()
        {
            int product = 1;
            while (_number > 0)
            {
                product *= _number % 10;
                _number /= 10;
            }
            return product;
        }

        public static Task Create(int number)
        {
            return new Task(number);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Task task1 = new Task(123);
            int product1 = task1.MultiplyDigits();
            Console.WriteLine(product1); // Output: 6

            Task task2 = new Task();
            task2.Number = 456;
            int product2 = task2.MultiplyDigits();
            Console.WriteLine(product2); // Output: 120

            Task task3 = Task.Create(789);
            int product3 = task3.MultiplyDigits();
            Console.WriteLine(product3); // Output: 504
        }
    }
}