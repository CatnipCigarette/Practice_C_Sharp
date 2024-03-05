using System;
using System.Threading.Tasks;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] values = new double[11];

            Parallel.For(0, 11, i =>
            {
                double x = 5 + i;
                values[i] = Math.Acos(x);
                Console.WriteLine($"Arccos({x}) = {values[i]}");
            });
        }
    }
}