using System;

namespace MyNameSpace
{
    class Trial
    {
        public string name;
        public int sb;
        public Trial(string name, int sb)
        {
            this.name = name;
            this.sb = sb;
        }
        virtual public void Vivod()
        {
            Console.WriteLine($"{name} средний балл за семестр: {sb}");
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Trial temp = (Trial)obj;
            return sb == temp.sb;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public virtual void Proverka()
        {

        }
    }
    class Test : Trial
    {
        int mark;
        public Test(int mark, string name, int sb) : base(name, sb)
        {
            this.mark= mark;

        }
        public override void Vivod()
        {
            Console.WriteLine($"{name} получил за итоговый тест {mark} ");
        }
        public override void Proverka()
        {
            if (mark>= 4)
                Console.WriteLine(name + " сдал тест\nОтметка за тест: " + mark);
            else
                Console.WriteLine(name + " не сдал тест\nОценка за тест: " + mark);
        }

    }
    class Exam : Trial
    {
        string ter;
        int mark;
        public Exam(int mark, string name, int sb, string ter) : base(name, sb)
        {
            this.ter = ter;
            this.mark= mark;
        }
        public override void Vivod()
        {
            Console.WriteLine($"{name} сдал экзамен на {mark} по {ter}");
        }
        public override void Proverka()
        {
            if (mark>= 4)
                Console.WriteLine($"{name} сдал экзамен на {mark}");
            else
                Console.WriteLine(name + " не сдал экзамен, оценка " + mark);
        }
    }
    class FinalExam : Trial
    {
        int mark;
        public FinalExam(int mark, string name, int sb) : base(name, sb)
        {
            this.mark= mark;
        }
        public override void Vivod()
        {
            Console.WriteLine("{0} сдал выпускной экзамен на {1} ", name, mark);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trial[] p = new Trial[5];
            p[0] = new Trial("Иванов И.И.", 5);
            p[1] = new Test(2, "Петров П.П.", 8);
            p[2] = new Exam(6, "Иванов", 5, "ЗКИ");
            p[3] = new Trial("Петров П.П.", 7);
            p[4] = new FinalExam(5, "Петров", 7);
            foreach (var item in p)
            {
                item.Vivod();
            }
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Узнать сдал ли тест {0}\n1-да 2-нет", p[1].name);
            int y = int.Parse(Console.ReadLine());
            if (y == 1)
                p[1].Proverka();
            Console.WriteLine();
            Console.WriteLine("Узнать сдал ли {0} экзамен\n1-да 2-нет", p[2].name);
            y = int.Parse(Console.ReadLine());
            if (y == 1)
                p[2].Proverka();
            Console.WriteLine();
            Console.WriteLine($"Сравнить средний балл за семестр {p[0].name} и {p[3].name}\n1-да 2-нет");
            y = int.Parse(Console.ReadLine());
            if (y == 1)
            {
                Console.WriteLine($"Средние баллы\nИванов: {p[0].sb}\nПетров: {p[3].sb}");
                if (p[0].Equals(p[3]))
                    Console.WriteLine("Значение равны");
                else
                    Console.WriteLine("Не равны");
            }
            Console.ReadKey();
        }

    }
}