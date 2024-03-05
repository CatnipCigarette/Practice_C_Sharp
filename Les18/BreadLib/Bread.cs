namespace BreadLib
{
    public class Bread
    {
        double weight; 

        public enum BreadtType
        {
            Black,
            White
        }

        BreadtType type;

        public Bread(BreadtType type, double weight)
        {
            if (!BreadChek(weight))
            {
                throw new Exception("У вас нет хлеба :(");
            }
            else
            {
                this.type = type;
                this.weight = weight;
            }
        }

        public bool BreadChek(double weight)
        {
            bool HaveBread = weight > 0;
            return HaveBread;
        }

        public double Kcal()
        {
            double kcalIn100, kcal;
            if (type == BreadtType.Black)
            {
                kcalIn100 = 222;
                kcal = kcalIn100 * (weight / 100);
                return kcal;
            }
            else if (type == BreadtType.White)
            {
                kcalIn100 = 265;
                kcal = kcalIn100 * (weight / 100);
                return kcal;
            }
            else 
            {
                throw new Exception("Странный хлеб!");
            }
        }
    }
}