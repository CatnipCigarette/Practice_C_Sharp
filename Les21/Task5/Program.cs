namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 43, 16, 92 };
            int sum = 0;
            int product = 1;
            bool breakSum = false;
            bool breakProduct = false;

            Parallel.ForEach(arr, (n, state) =>
            {
                sum += n;
                if (sum > 535 && !breakSum)
                {
                    state.Break();
                    breakSum = true;
                }

                product *= n;
                if (product > 535 && !breakProduct)
                {
                    state.Break();
                    breakProduct = true;
                }
            });

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
        }
    }
}