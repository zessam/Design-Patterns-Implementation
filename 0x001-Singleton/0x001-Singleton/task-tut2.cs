// dy el task 3l4an ttbsty ya **Ghada** ya rab trdy 3ny 

using System;
using System.Collections.Generic;

namespace Singleton_Design_Pattern
{
    public class GameLobby
    {
        private static GameLobby instance;
        private List<string> players;

        // Private constructor to prevent direct instantiation
        private GameLobby()
        {
            players = new List<string>();
        }

        // Public method to access the single instance of GameLobby
        public static GameLobby GetInstance()
        {
            if (instance == null)
            {
                instance = new GameLobby();
            }
            return instance;
        }

        public void AddPlayer(string playerName)
        {
            players.Add(playerName);
            Console.WriteLine($"{playerName} has joined the game lobby.");
        }

        public void RemovePlayer(string playerName)
        {
            players.Remove(playerName);
            Console.WriteLine($"{playerName} has left the game lobby.");
        }

        public void ListPlayers()
        {
            Console.WriteLine("Players in the game lobby:");

            foreach (string player in players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
