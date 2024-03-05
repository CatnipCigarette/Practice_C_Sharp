using System;

namespace MyNamespace
{
    class Autobus
    {
        private int passengers;
        private decimal ticketPrice;

        public Autobus(int passengers, decimal ticketPrice)
        {
            this.passengers = passengers;
            this.ticketPrice = ticketPrice;
        }

        public int Passengers
        {
            get { return passengers; }
            set { passengers = value; }
        }

        public decimal TicketPrice
        {
            get { return ticketPrice; }
            set { ticketPrice = value; }
        }

        public virtual decimal TotalCost()
        {
            return passengers * ticketPrice;
        }
    }

    class Skory : Autobus
    {
        private double speed;
        private string brand;

        public Skory(int passengers, decimal ticketPrice, double speed, string brand)
            : base(passengers, ticketPrice)
        {
            this.speed = speed;
            this.brand = brand;
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public override decimal TotalCost()
        {
            decimal increasedTicketPrice = TicketPrice * (decimal)(1 + 0.05 * speed);
            return Passengers * increasedTicketPrice;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Autobus bus = new Autobus(50, 10.0m);
            Console.WriteLine($"Пассажиры автобуса: {bus.Passengers}\nЦена билета: {bus.TicketPrice}\nОбщая стоимость: {bus.TotalCost()}");

            Console.WriteLine();

            Skory expressBus = new Skory(50, 10.0m, 100.0, "Мерседес");
            Console.WriteLine($"Пассажиры экспресс-автобуса: {expressBus.Passengers}\nСтоимость билета: {expressBus.TicketPrice}\nСкорость: {expressBus.Speed}\nМарка: {expressBus.Brand}\nОбщая стоимость: {expressBus.TotalCost()}");
        }
    }
}
