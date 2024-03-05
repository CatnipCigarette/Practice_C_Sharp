using System;

namespace Space
{
    class Furniture
    {
        public string Name { get; set; }

        public virtual double GetCost()
        {
            return 0;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Название: {Name}");
        }
    }

    class Wardrobe : Furniture
    {
        public double Volume { get; set; }

        public override double GetCost()
        {
            return Math.Sqrt(Volume) * 0.75;
        }

        public override void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Название: {Name}\nОбъём: {Volume} см^3\nЦена: {Math.Round(GetCost())} руб.");
        }
    }

    class Sofa : Furniture
    {
        public double Area { get; set; }

        public override double GetCost()
        {
            return (Math.Pow(Area, 2) / 3) + 5000;
        }

        public override void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Название: {Name}\nПлощадь: {Area} см^2\nЦена: {Math.Round(GetCost())} руб.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Furniture[] furnitureArray = new Furniture[5];
            furnitureArray[0] = new Furniture { Name = "Стол Крик" };
            furnitureArray[1] = new Wardrobe { Name = "Шкаф Нарния", Volume = 5000 };
            furnitureArray[2] = new Sofa { Name = "Диван Победа", Area = 3000 };
            furnitureArray[3] = new Wardrobe { Name = "Шкаф Крыша", Volume = 7000 };
            furnitureArray[4] = new Sofa { Name = "Диван Ландыши", Area = 4000 };

            Console.WriteLine("Мебельный каталог:");
            foreach (Furniture f in furnitureArray)
            {
                f.PrintInfo();
            }

            Console.ReadKey();
        }
    }
}