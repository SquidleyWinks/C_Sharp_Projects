﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CasinoHell;
using CasinoHell.Blackjack;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hell. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to wager your soul on a game of Blackjack? Answer Carefully.", playerName);
            string answer = Console.ReadLine();
            if (answer != "" || answer == "")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"c:\users\puebbing\documents\logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new BlackjackGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("So you've survived. \n For Now.");
            }
            Console.WriteLine("Feel free to get comfortable. You'll still be here for a while.");
            Console.Read();
        }
    }
}
