namespace ShapeLib
{
    public class Triangle
    {
        public double a, b, c; double P;

        public enum type
        {
            Isosceles,
            Equilateral,
            Versatile
        }

        public Triangle(double a, double b, double c)
        {

            if (!IsExistTriangle(a, b, c))
            {
                throw new Exception("Треугольник не существует!");
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public bool IsExistTriangle(double a, double b, double c)
        {
            bool prov = ((a > 0) && (b > 0) && (c > 0) && ((a+b>c)&&(b+c>a)&&(a+c>b)));
            return prov;
        }

        public double Perimetr()
        {
            P = a + b + c;
            return P;
        }

        public double Square()
        {
            double S = Math.Sqrt(P * (P - a) * (P - c) * (P - b));
            return S;
        }

        public type TriangleType()
        {
            if (a == b && b == c)
            {
                return type.Equilateral;
            }
            else if ((a == b && a != c) || (b == c && b != a) || (a == c && a != b))
            {
                return type.Isosceles;
            }
            else
            {
                return type.Versatile;
            }
        }
    }
}