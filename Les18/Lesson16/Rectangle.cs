using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Rectanglee
    {
        public double a, b; double P;

        public Rectanglee(double a, double b)
        {
            if (!ExistTriangle(a, b))
            {
                throw new Exception("Прямоугольник не существует!");
            }
            else
            {
                this.a = a;
                this.b = b;
            }
        }

        public bool ExistTriangle(double a, double b)
        {
            bool prov = ((a > 0) && (b > 0));
            return prov;
        }

        public double Perimetr()
        {
            P = 2 * a + 2 * b;
            return P;
        }

        public double Square()
        {
            double S = a * b;
            return S;
        }
    }
}
