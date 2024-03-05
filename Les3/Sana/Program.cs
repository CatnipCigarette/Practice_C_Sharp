using System.Drawing;
using System.IO;

namespace MyNameSpace
{

    class Region
    {
        public string NameOfReg { get; set; }

        public Region(string nameOfReg)
        {
            NameOfReg = nameOfReg;
        }

        public static implicit operator Region(string v)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Регион: " + NameOfReg);
        }
    }

    class City : Region
    {
        public City(string nameOfReg) : base(nameOfReg)
        {
        }

        public string NameCit { get; set; }

        public static implicit operator City(string v)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Город: " + NameCit);
        }
    }

    class Metropolis : Region
    {
        public Metropolis(string nameOfReg) : base(nameOfReg)
        {
        }

        public string NameMet { get; set; }

        public static implicit operator Metropolis(string v)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Мегаполис: " + NameMet);
        }
    }

    class Place : Region
    {
        public Place(string nameOfReg) : base(nameOfReg)
        {
        }

        public string NamePl { get; set; }

        public static implicit operator Place(string v)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Место встречи: " + NamePl);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите регион(страну): ");
            string NReg = Convert.ToString(Console.ReadLine());
            Region region = new Region(NReg);

            Console.Write("Город или Мегаполис (1/2): ");
            int Ans = Convert.ToInt32(Console.ReadLine());

            string NCit = " ";
            string NMeg = " ";

            if (Ans == 1)
            {
                Console.Write("Введите название города: ");
                NCit = Convert.ToString(Console.ReadLine());

            }
            else if (Ans == 2)
            {
                Console.Write("Введите название мегаполиса: ");
                NMeg = Convert.ToString(Console.ReadLine());
            }

            City city = new City(NCit);
            Metropolis metropolis = new Metropolis(NMeg);

            Console.Write("Введите место встречи: ");
            string NPL = Convert.ToString(Console.ReadLine());
            Place place = new Place(NPL);

            if (Ans == 1)
            {
                region.Print();
                city.Print();
                place.Print();
            }
            else if (Ans == 2)
            {
                region.Print();
                metropolis.Print();
                place.Print();
            }

        }

    }
}