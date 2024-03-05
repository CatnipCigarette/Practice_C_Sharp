namespace Space
{
    /// <summary>
    /// Класс, реализующий простейшие арифметические операции над двумя числами.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Делегат, описывающий метод для выполнения арифметических действий.
        /// </summary>
        /// <param name="a">Первый операнд.</param>
        /// <param name="b">Второй операнд.</param>
        /// <returns>Результат арифметической операции.</returns>
        delegate double Calc(double a, double b);

        static void Main(string[] args)
        {
            // Создаем четыре лямбда оператора для выполнения арифметических действий
            Calc Add = (a, b) => a + b;
            Calc Sub = (a, b) => a - b;
            Calc Mul = (a, b) => a * b;
            Calc Div = (a, b) => b != 0 ? a / b : throw new DivideByZeroException();

            // Запрашиваем у пользователя два числа и операцию
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Введите операцию (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            // Выбираем соответствующий лямбда оператор в зависимости от операции
            Calc calc;
            switch (op)
            {
                case '+':
                    calc = Add;
                    break;
                case '-':
                    calc = Sub;
                    break;
                case '*':
                    calc = Mul;
                    break;
                case '/':
                    calc = Div;
                    break;
                default:
                    Console.WriteLine("Неправильная операция");
                    return;
            }
            // Вычисляем результат и выводим его на экран
            try
            {
                double result = calc(num1, num2);
                Console.WriteLine($"Результат: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль");
            }
        }
    }
}