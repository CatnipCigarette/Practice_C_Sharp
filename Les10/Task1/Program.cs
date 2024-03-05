using System;

namespace MySpase
{
    interface Ix
    {
        void IxF0(int inter);
        void IxF1();
    }

    interface Iy
    {
        void F0(int inter);
        void F1();
    }

    interface Iz
    {
        void F0(int inter);
        void F1();
    }

    class TestClass : Ix, Iy, Iz
    {
        private int w;

        public TestClass(int w)
        {
            this.w = w;
        }

        // Неявная реализация интерфейсов Ix, Iy и Iz
        public void IxF0(int inter)
        {
            Console.WriteLine("IxF0: " + (10 * w - 10));
        }

        public void IxF1()
        {
            Console.WriteLine("IxF1: " + (10 * w - 10));
        }

        void Iy.F0(int inter)
        {
            Console.WriteLine("Iy.F0: " + (10 * w - 10));
        }

        void Iy.F1()
        {
            Console.WriteLine("Iy.F1: " + (10 * w - 10));
        }

        // Явная реализация интерфейса Iz
        void Iz.F0(int inter)
        {
            Console.WriteLine("Iz.F0: " + (w / 10));
        }

        void Iz.F1()
        {
            Console.WriteLine("Iz.F1: " + (w / 10));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass(15);

            // Вызов методов через интерфейсную ссылку
            Ix ix = test;
            ix.IxF0(15);
            ix.IxF1();

            Iy iy = test;
            iy.F0(15);
            iy.F1();

            Iz iz = test;
            iz.F0(15);
            iz.F1();

            // Вызов методов с явным приведением к типу интерфейса
            ((Iy)test).F0(15);
            ((Iy)test).F1();

            ((Iz)test).F0(15);
            ((Iz)test).F1();

            Console.ReadLine();
        }
    }
}