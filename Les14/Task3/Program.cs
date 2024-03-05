using System;

namespace Space
{
    class MyInfo
    {
        private string name;

        // создание события для оповещения об изменении поля name
        public event EventHandler NameChanged;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != name)
                {
                    name = value;
                    OnNameChanged();
                }
            }
        }

        // метод для вызова события
        protected virtual void OnNameChanged()
        {
            NameChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main()
        {
            MyInfo info = new MyInfo();
            info.NameChanged += OnNameChanged;
            info.Name = "Екатерина";

            Console.Write("Введите новое имя: ");
            string NewName = Console.ReadLine();
            info.Name = NewName;
        }

        static void OnNameChanged(object sender, EventArgs e)
        {
            MyInfo info = (MyInfo)sender;
            Console.WriteLine("Имя установлено: " + info.Name);
        }
    }
}