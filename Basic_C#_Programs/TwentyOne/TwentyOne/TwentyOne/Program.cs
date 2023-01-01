using System;
using Casino;
using Casino.TwentyOne;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Saves casino name into a variable so it is able to be referenced later
            const string casinoName = "Grand Hotel and Casino";

            //Asks the user for their name
            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            //Saves users name into a variable
            string playerName = Console.ReadLine();
            //Asks user how much money they have
            Console.WriteLine("How much money did you bring today?");
            //Saves how much money the user has into a variable
            int bank = Convert.ToInt32(Console.ReadLine());
            //Asks user if they want to play a game of 21
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            //Saves users input into a variable and transforms it into lowercase
            string answer = Console.ReadLine().ToLower();
            //Says that if the users input is equal to yes etc. to instansiate a new player, a new game,
            //add the player to the game and set the start the game.
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\mmcmi\OneDrive\Documents\School\C-Sharp-Projects\Basic_C#_Programs\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                //Says that while isActively playing is equal to true and the player has a balance 
                //greater than 0, to play the game. If not, remove the player from the game.
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
    }
 }
