using System;
using System.IO;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\Учёба\Практика по пр\Les17\numbers.txt"; // путь к файлу с числами
            int min = int.MaxValue; // начальное значение минимума - максимальное значение типа int
            int positiveCount = 0; // счетчик положительных чисел

            // открыть файл и считать числа
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                string[] numbers = line.Split(' ');

                foreach (string strNum in numbers)
                {
                    if (int.TryParse(strNum, out int num))
                    {
                        // если удалось прочитать число
                        if (num < min)
                        {
                            min = num; // обновить минимум, если найдено меньшее число
                        }
                        if (num > 0)
                        {
                            positiveCount++; // увеличить счетчик положительных чисел
                        }
                    }
                }
            }

            Console.WriteLine("Минимальное число: " + min);
            Console.WriteLine("Количество положительных чисел: " + positiveCount);
        }
    }
}