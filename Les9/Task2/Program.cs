namespace MySpace
{
    static class Accountant
    {
        public enum CompanyEmployees
        {
            ДиректорПочты = 100,
            Юрист = 150,
            Экономист = 200,
            Почтальон = 220,
            ОператорПочтовойСвязи = 150
        }

        public static bool AskForBonus(CompanyEmployees postWorker, int hours)
        {
            return hours > (int)postWorker;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CheckBonus(Accountant.CompanyEmployees.ДиректорПочты, 67);
            CheckBonus(Accountant.CompanyEmployees.Юрист, 220);
            CheckBonus(Accountant.CompanyEmployees.Экономист, 300);
            CheckBonus(Accountant.CompanyEmployees.Почтальон, 250);
            CheckBonus(Accountant.CompanyEmployees.ОператорПочтовойСвязи, 280);
            Console.ReadLine();
        }

        static void CheckBonus(Accountant.CompanyEmployees postWorker, int hours)
        {
            string answer = string.Format("Должность работника: {0} \nЧасы работы за месяц: {1} \nВыдача бонуса: ", postWorker, hours);
            answer += Accountant.AskForBonus(postWorker, hours) ? "Выдать премию" : "Не выдавать премию";
            Console.WriteLine(answer);
        }
    }
}
