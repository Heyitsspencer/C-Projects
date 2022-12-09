using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop
            int i = 0; //initialization 
            while (i < 10)//conditional statement
            {
                Console.WriteLine("i = {0}", i);

                i++; //increment i up by one
            }
            //Do While Loop
            Console.WriteLine("Guess a letter:");
            string letter = Console.ReadLine();
            bool isGuessed = (false);
            do
            {
                switch (letter)
                {
                    case "x":
                        Console.WriteLine("You guessed x. Try Again.");//tells user they guessed the wrong letter
                        Console.WriteLine("Guess a letter:");//prompts user to guess again
                        letter = Console.ReadLine();
                        break;
                    case "q":
                        Console.WriteLine("You guessed q. Try Again.");
                        Console.WriteLine("Guess a letter:");//prompts user to guess again
                        letter = Console.ReadLine();
                        break;
                    case "a":
                        Console.WriteLine("You guessed a. Try Again.");
                        Console.WriteLine("Guess a letter:");//prompts user to guess again
                        letter = Console.ReadLine();
                        break;
                    case "o":
                        Console.WriteLine("You guessed o. That is correct!.");//Tells user they guessed correctly
                        isGuessed = true; //sets isGuessed to true so it ends the do while loop
                        break;
                    default:
                        Console.WriteLine("You're wrong. ");
                        Console.WriteLine("Guess a letter:");
                        letter = Console.ReadLine();
                        break;


                }
            }
            while (!isGuessed);

            Console.ReadLine();


        }
        }
    }

