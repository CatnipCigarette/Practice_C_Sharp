using System;
using System.Collections.Generic;

namespace Space
{
    abstract class Sport
    {
        protected List<string> players;

        public Sport()
        {
            players = new List<string>();
        }

        public abstract void Play();

        public void AddPlayer(string player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string player)
        {
            players.Remove(player);
        }

        public Sport Clone()
        {
            return (Sport)this.MemberwiseClone();
        }

        public void PrintPlayers()
        {
            Console.WriteLine();
            Console.Write("Список игроков: ");
            foreach (string player in players)
            {
                Console.Write(player + " ");
            }
            Console.WriteLine();
        }

        public void AddPlayers(int a)
        {
            int i = 0;
            while (i < a)
            {
                Console.Write("Введите имя игрока: ");
                string playerName = Console.ReadLine();
                AddPlayer(playerName);
                i++;
            }
        }

        public void RemovePlayers(int b)
        {
            int i = 0;
            while (i < b)
            {
                Console.Write("Введите имя игрока, которого нужно выгнать: ");
                string playerName = Console.ReadLine();
                RemovePlayer(playerName);
                i++;
            }
        }
    }

    class Football : Sport
    {
        public override void Play()
        {
            Console.WriteLine();
            Console.WriteLine("Играем в футбол с {0} игроками", players.Count);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько человек играет: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Football football = new Football();
            football.AddPlayers(a);
            football.PrintPlayers();
            football.Play();

            Console.Write("Сколько человек выгоняем: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Football football2 = football.Clone() as Football;
            football2.RemovePlayers(b);
            football2.PrintPlayers();
            football2.Play();
        }
    }
}
