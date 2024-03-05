using System;

namespace Space
{
    class MyClass
    {
        // определяем делегат
        public delegate void MyDelegate(string message);

        // определяем событие на основе делегата
        public event MyDelegate MyEvent;

        // метод, который будет вызывать событие
        public void RaiseEvent(string message)
        {
            MyEvent?.Invoke(message);
        }
    }

    // создаем класс-наблюдатель 
    class Observer1
    {
        // метод для обработки события
        public void HandleEvent(string message)
        {
            Console.WriteLine("Проверка №1: " + message);
        }
    }

    class Observer2
    {
        public void HandleEvent(string message)
        {
            Console.WriteLine("Проверка №2: " + message);
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();

            myClass.MyEvent += observer1.HandleEvent;
            myClass.MyEvent += observer2.HandleEvent;
            myClass.MyEvent += observer1.HandleEvent;
            myClass.MyEvent += observer2.HandleEvent;

            // вызываем метод, который запускает событие
            myClass.RaiseEvent("Событие произошло!");

            // отписываем один обработчик от события
            myClass.MyEvent -= observer1.HandleEvent;

            // вызываем метод, который запускает событие
            myClass.RaiseEvent("Событие произошло еще раз!");

            Console.ReadLine();
        }
    }
}