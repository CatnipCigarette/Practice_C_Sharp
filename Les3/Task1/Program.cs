namespace MyNamespace
{
    public class Numbs
    {

        public double a;
        public double b;

        public Numbs(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double F(double a, double b)
        {
            return (1 / (1 + ((a + b) / 2)));
        }

        public double Pow(double a, double b)
        {
            return Math.Pow(a - b, 2);
        }

        public void Write()
        {
            Console.Write("Значение заданного выражения с числами {0} и {1}: ", a, b);
            Console.WriteLine(F(a, b));
            Console.Write("Разность {0} и {1} в квадрате: ", a, b);
            Console.WriteLine(Pow(a, b));
        }

    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Numbs numbs = new Numbs(a, b);

            numbs.Write();
            Console.WriteLine();

        }
    }
}
