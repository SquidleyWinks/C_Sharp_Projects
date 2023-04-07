using System;
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

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("If you had to put a value on your soul, what would it be worth?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Don't be precious -- give me a number.");
            }

            Console.WriteLine("Hello, {0}. Would you like to wager your meager soul on a game of Blackjack? Answer Carefully.", playerName);
            string answer = Console.ReadLine();
            Console.WriteLine("Ha, you couldn't resist, even if you wanted to.");
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
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("You have attempted to cheat Hell. Prepare to go someplace worse.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured. The Devil will be contacting you shortly.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("So you've survived. \n For Now.");
            }
            Console.WriteLine("Feel free to get comfortable. You'll still be here for a while.");
            Console.Read();
        }
    }
}
