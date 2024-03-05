using System;
using System.Collections;

namespace MusicCatalog
{
    class Catalog
    {
        private Hashtable discs = new Hashtable();

        public void AddDisc(string title)
        {
            discs[title] = new Hashtable();
        }

        public void RemoveDisc(string title)
        {
            discs.Remove(title);
        }

        public void AddSong(string discTitle, string songTitle)
        {
            Hashtable disc = discs[discTitle] as Hashtable;
            if (disc != null)
            {
                disc[songTitle] = true;
            }
        }

        public void RemoveSong(string discTitle, string songTitle)
        {
            Hashtable disc = discs[discTitle] as Hashtable;
            if (disc != null)
            {
                disc.Remove(songTitle);
            }
        }

        public void ViewCatalog()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Каталог музыки:");
            Console.ResetColor();

            foreach (string discTitle in discs.Keys)
            {
                Console.WriteLine("- {0}", discTitle);

                Hashtable disc = discs[discTitle] as Hashtable;
                if (disc != null)
                {
                    foreach (string songTitle in disc.Keys)
                    {
                        Console.WriteLine("  * {0}", songTitle);
                    }
                }
                Console.WriteLine();
            }
        }

        public void ViewDisc(string discTitle)
        {
            int i = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Диск {0} содержит:", discTitle);
            Console.ResetColor();

            Hashtable disc = discs[discTitle] as Hashtable;
            if (disc != null)
            {
                foreach (string songTitle in disc.Keys)
                {
                    i++;
                    Console.WriteLine(" {0}){1}", i, songTitle);
                }
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            // добавление дисков и песен
            catalog.AddDisc("Appetite for Destruction - Guns N' Roses");
            catalog.AddSong("Appetite for Destruction - Guns N' Roses", "Welcome to the Jungle");
            catalog.AddSong("Appetite for Destruction - Guns N' Roses", "Sweet Child O' Mine");
            catalog.AddSong("Appetite for Destruction - Guns N' Roses", "Paradise City");

            catalog.AddDisc("Nevermind - Nirvana");
            catalog.AddSong("Nevermind - Nirvana", "Smells Like Teen Spirit");
            catalog.AddSong("Nevermind - Nirvana", "Come as You Are");
            catalog.AddSong("Nevermind - Nirvana", "Lithium");

            catalog.AddDisc("Back in Black - AC/DC");
            catalog.AddSong("Back in Black - AC/DC", "Hells Bells");
            catalog.AddSong("Back in Black - AC/DC", "Back in Black");
            catalog.AddSong("Back in Black - AC/DC", "You Shook Me All Night Long");

            catalog.AddDisc("Dark Side of the Moon - Pink Floyd");
            catalog.AddSong("Dark Side of the Moon - Pink Floyd", "Speak to Me");
            catalog.AddSong("Dark Side of the Moon - Pink Floyd", "Breathe");
            catalog.AddSong("Dark Side of the Moon - Pink Floyd", "Money");

            catalog.AddDisc("Master of Puppets - Metallica");
            catalog.AddSong("Master of Puppets - Metallica", "Battery");
            catalog.AddSong("Master of Puppets - Metallica", "Master of Puppets");
            catalog.AddSong("Master of Puppets - Metallica", "Orion");

            catalog.AddDisc("Ten - Pearl Jam");
            catalog.AddSong("Ten - Pearl Jam", "Once");
            catalog.AddSong("Ten - Pearl Jam", "Alive");
            catalog.AddSong("Ten - Pearl Jam", "Black");

            // просмотр всего каталога
            catalog.ViewCatalog();

            // просмотр содержимого диска
            catalog.ViewDisc("Nevermind - Nirvana");

            // удаление песен и дисков
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("УДАЛЕНЯЕМ АЛЬБОМ И КОМПОЗИЦИЮ");
            catalog.RemoveSong("Master of Puppets - Metallica", "Orion");
            catalog.RemoveDisc("Ten - Pearl Jam");
            Console.WriteLine();
            Console.ResetColor();

            // просмотр всего каталога после удаления
            catalog.ViewCatalog();
        }
    }
}
