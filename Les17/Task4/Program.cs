using System;
using System.IO;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"E:\Учёба\Практика по пр\Les17\1.txt";
            string path2 = @"E:\Учёба\Практика по пр\Les17\2.txt";
            string pathTemp1 = @"E:\Учёба\Практика по пр\Les17\temp1.txt";
            string pathTemp2 = @"E:\Учёба\Практика по пр\Les17\temp2.txt";

            // Открыть поток для чтения из первого файла
            using (StreamReader sr1 = new StreamReader(path1))
            {
                // Открыть поток для чтения из второго файла
                using (StreamReader sr2 = new StreamReader(path2))
                {
                    // Открыть поток для записи во временный файл 1
                    using (StreamWriter swTemp1 = new StreamWriter(pathTemp1))
                    {
                        // Открыть поток для записи во временный файл 2
                        using (StreamWriter swTemp2 = new StreamWriter(pathTemp2))
                        {
                            // Переписать строки первого файла во второй, а строки второго файла - в первый
                            string line1, line2;
                            while ((line1 = sr1.ReadLine()) != null && (line2 = sr2.ReadLine()) != null)
                            {
                                swTemp1.WriteLine(line2);
                                swTemp2.WriteLine(line1);
                            }
                        }
                    }
                }
            }

            // Удалить исходные файлы и переименовать временные файлы в исходные
            File.Delete(path1);
            File.Delete(path2);
            File.Move(pathTemp1, path1);
            File.Move(pathTemp2, path2);

            Console.WriteLine("Файлы успешно переписаны!");
        }
    }
}
