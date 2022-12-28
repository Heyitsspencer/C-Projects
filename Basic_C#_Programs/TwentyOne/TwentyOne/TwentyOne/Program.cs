using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            //Polymorphism
            //Game game = new TwentyOneGame();


            //Game game = new Game();
            //game.Players = new List<string>() { "Spencer", "Shannon", "Steven" };
            //game.ListPlayers();
            //Console.ReadLine();

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Spencer";
            //game += player;
            //game -= player;

            Deck deck = new Deck();
            deck.Shuffle(3);


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
 }
