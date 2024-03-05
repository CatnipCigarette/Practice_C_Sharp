using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyNamespace
{
    class Program
    {

        public static void Main()
        {
            double F(double n)
            {
                if (n == 1) return 1;

                return n * F(n - 1);
            }

            Console.Write("Введите n: ");
            double n = Convert.ToInt32(Console.ReadLine());

            double f = F(1 + n) / F(n);
            Console.WriteLine("F(" + n + ") = " + f);
        }
    }
}