using System.IO;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"E:\Учёба\Практика по пр\Les17\New_folder"; // путь к создаваемой папке

            // создать папку, если её нет
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Папка создана успешно!");
            }
            else
            {
                Console.WriteLine("Папка уже существует!");
            }
        }
    }
}