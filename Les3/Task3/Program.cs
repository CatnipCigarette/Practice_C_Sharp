using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySpace
{

    class DateExcepts : Exception
    {
        public override string Message
        {
            get
            {
                return "Ошибка ввода значений даты.";
            }
        }
    }
    class DayExcept : DateExcepts
    {
        public override string Message
        {
            get
            {
                return base.Message + " Вы ввели недопустимое значение для переменной День. Введенное вами число превышает количество дней в этом месяце.";
            }
        }
    }
    class MonthExcept : DateExcepts
    {
        public override string Message
        {
            get
            {
                return base.Message + " Вы ввели недопустимое значение для переменной Месяц.";
            }
        }
    }
    class YearExcept : DateExcepts
    {
        public override string Message
        {
            get
            {
                return base.Message + " Вы ввели недопустимое значение для переменной Год.";
            }
        }
    }

    public class MyDate
    {
        private int Day;
        private int Month;
        private int Year;
        private int NDay;
        private int NMonth;
        private int NYear;

        public MyDate()
        {
            Day = 0;
            Month = 0;
            Year = 0;
            NDay = 0;
            NMonth = 0;
            NYear = 0;
        }

        public MyDate(int Day, int Month, int Year, int NDay, int NMonth, int NYear)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
            this.NDay = NDay;
            this.NMonth = NMonth;
            this.NYear = NYear;

        }


        public void SetMonth(int Month)
        {
            if (Month < 1 || Month > 12)
                throw new MonthExcept();
            else this.Month = Month;


        }

        public int getMonth()
        {

            return Month;
        }


        public void SetDay(int Day)
        {

            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (Day < 1 || Day > 31)
                        throw new DayExcept();
                    else this.Day = Day;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    if (Day < 1 || Day > 30)
                        throw new DayExcept();
                    else this.Day = Day;
                    break;
                case 2:
                    if (Day < 1 || Day > 29)
                        throw new DayExcept();
                    else this.Day = Day;
                    break;

            }

        }

        public int getDay()
        {


            return Day;
        }


        public void SetYear(int Year)
        {
            if (Year < 1 || Year > 2050)
                throw new YearExcept();
            else this.Year = Year;

        }

        public int getYear()
        {

            return Year;
        }


        public void SetNDay(int d, int y1)
        {
            if (y1 > 1)
            {
                if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
                {

                }
            }


        }

        public int getNDay()
        {

            return NDay;
        }

        public void SetNMonth(int m, int y1)
        {
            if (y1 > 1)
            {
                if (Month + m > 12)
                {
                    this.NMonth = m - Month - 2;
                    this.Year = ++Year;
                }

                else this.NMonth = m + Month;
            }

            else

            {
                if (Month - m < 1)
                {

                    this.NMonth = m - Month - 2;
                    this.Year = --Year;
                }
                else this.NMonth = Month - m;

            }




        }

        public int getNMonth()
        {

            return NMonth;
        }

        public void SetNYear(int y, int y1)
        {
            if (y1 > 1) this.NYear = Year + y;
            else this.NYear = Year - y;


        }

        public int getNYear()
        {

            return NYear;
        }

    }





    class Program
    {
        static void Main()
        {
            bool otvet = false;
            int day, month, year, d, m, y, y1 = 1, n;
            string buf;
            MyDate date = new MyDate();

            Console.Write("Введите месяц: ");
            buf = Console.ReadLine();
            month = Int32.Parse(buf);
            date.SetMonth(month);
            Console.Write("Введите день: ");
            buf = Console.ReadLine();
            day = Int32.Parse(buf);
            date.SetDay(day);
            Console.Write("Введите год: ");
            buf = Console.ReadLine();
            year = Int32.Parse(buf);
            date.SetYear(year);
            try
            {
                Console.WriteLine();
                Console.Write("Введённая дата: ");
                Console.WriteLine(date.getDay() + "." + date.getMonth() + "." + date.getYear());
                Console.ReadLine();
            }
            catch (DateExcepts e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine();
                Console.WriteLine("Хотите ли изменить дату? " +
                                    "\n1. Да      2. Нет");

                int otv = Convert.ToInt32(Console.ReadLine());
                if (otv == 1 || otv == 2) otvet = true;

                if (otvet)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. День ");
                    Console.WriteLine("2. Месяц ");
                    Console.WriteLine("3. Год ");
                }
                buf = Console.ReadLine();
                n = Int32.Parse(buf);
                switch (n)
                {

                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("1. Увеличить ");
                        Console.WriteLine("2. Уменьшить ");
                        buf = Console.ReadLine();
                        n = Int32.Parse(buf);
                        Console.WriteLine();
                        Console.Write("Введите число на которое изменяется значение дня: ");
                        buf = Console.ReadLine();
                        d = Int32.Parse(buf);
                        switch (n)
                        {
                            case 1:
                                ++y1;
                                date.SetNDay(d, y1);
                                break;
                            case 2:
                                --y1;
                                date.SetNDay(d, y1);
                                break;
                        }

                        Console.WriteLine();
                        Console.WriteLine(date.getNDay() + "." + date.getMonth() + "." + date.getYear());


                        break;


                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("1. Увеличить ");
                        Console.WriteLine("2. Уменьшить ");
                        buf = Console.ReadLine();
                        n = Int32.Parse(buf);
                        Console.WriteLine();
                        Console.Write("Введите число на которое изменяется значение месяца: ");
                        buf = Console.ReadLine();
                        m = Int32.Parse(buf);
                        switch (n)
                        {
                            case 1:
                                ++y1;
                                date.SetNMonth(m, y1);
                                break;
                            case 2:
                                --y1;
                                date.SetNMonth(m, y1);
                                break;
                        }

                        Console.WriteLine();
                        Console.WriteLine(date.getDay() + "." + date.getNMonth() + "." + date.getYear());


                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("1. Увеличить ");
                        Console.WriteLine("2. Уменьшить ");
                        buf = Console.ReadLine();
                        n = Int32.Parse(buf);
                        Console.WriteLine();
                        Console.Write("Введите число на которое изменяется значение года: ");
                        buf = Console.ReadLine();
                        y = Int32.Parse(buf);
                        switch (n)
                        {
                            case 1:
                                ++y1;
                                date.SetNYear(y, y1);
                                break;
                            case 2:
                                --y1;
                                date.SetNYear(y, y1);
                                break;
                        }
                        Console.WriteLine();
                        Console.WriteLine(date.getDay() + "." + date.getMonth() + "." + date.getNYear());
                        break;
                }


                Console.ReadLine();
            }
            catch (DateExcepts e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}