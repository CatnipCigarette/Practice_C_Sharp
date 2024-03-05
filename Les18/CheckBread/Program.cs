using BreadLib;

namespace MyNameSpace
{
    public class Program
    {
        public static void Main()
        {
;           Console.Write("Введите вес хлеба: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите тип хлеба\n1. Белый\n2. Черный");
            int NumType = Convert.ToInt32(Console.ReadLine());
            Bread.BreadtType type;

            if (NumType == 1)
            {
                type = Bread.BreadtType.Black;
            }
            else 
            { 
                type = Bread.BreadtType.White;
            }

            try
            {
                Bread Joe = new(type, weight);

                Console.WriteLine("Кол-во ккал: " + Joe.Kcal());
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
        }
    }
}