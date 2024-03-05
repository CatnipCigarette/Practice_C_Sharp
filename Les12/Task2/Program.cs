using System;

namespace Space
{
    public abstract class Vector
    {
        public abstract void Print();
        public abstract double Length();
    }

    public class Vector2D : Vector
    {
        private double x;
        private double y;

        public Vector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Print()
        {
            Console.WriteLine("Двумерный вектор: ({0}, {1})", x, y);
        }

        public override double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }

    public class Vector3D : Vector
    {
        private double x;
        private double y;
        private double z;

        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override void Print()
        {
            Console.WriteLine("Трехмерный вектор: ({0}, {1}, {2})", x, y, z);
        }

        public override double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vector> vectors = new List<Vector>();

            vectors.Add(new Vector2D(1, 2));
            vectors.Add(new Vector3D(3, 4, 5));
            vectors.Add(new Vector2D(-1, 3));
            vectors.Add(new Vector3D(-2, 6, -3));
            vectors.Add(new Vector2D(4, -2));

            double totalLength = 0;

            foreach (Vector v in vectors)
            {
                v.Print();
                totalLength += v.Length();
            }

            Console.WriteLine("Суммарная длина векторов: {0}", totalLength);
        }
    }
}