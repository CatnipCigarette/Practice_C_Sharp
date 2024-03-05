namespace Space
{
    // Определяем интерфейс стратегии
    public interface IStrategy
    {
        void Execute();
    }

    // Реализуем конкретные стратегии
    public class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Выполняется конкретная стратегия A");
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Выполняется конкретная стратегия B");
        }
    }

    // Определяем класс контекста
    public class Context
    {
        private IStrategy _strategy;

        // Передаем стратегию через конструктор
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // Метод для выполнения стратегии
        public void ExecuteStrategy()
        {
            _strategy.Execute();
        }
    }

    // Пример использования
    public class Program
    {
        public static void Main()
        {
            // Создаем объекты стратегий
            var strategyA = new ConcreteStrategyA();
            var strategyB = new ConcreteStrategyB();

            // Создаем объекты контекста и передаем им стратегии
            var context1 = new Context(strategyA);
            var context2 = new Context(strategyB);

            // Выполняем стратегии через контекст
            context1.ExecuteStrategy(); // Вывод: Выполняется конкретная стратегия A
            context2.ExecuteStrategy(); // Вывод: Выполняется конкретная стратегия B
        }
    }
}