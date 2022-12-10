using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASSIGNMENT PART ONE 
            //Step 1- Add a one dimensional array of strings
            string[] stringArray = { "Mirabelle", "Goose", "Pigeon", "Diamond", "Ollie", "Harley" };
            //Step 2- Asks the user to input text
            Console.WriteLine("Enter your last name: ");
            //Saves user input into variable
            string userInput = Console.ReadLine();
            //Step 3- A loop that iterates through each string in the array and adds the user's text input 
            // to the end of each string 
            foreach (string name in stringArray)
            {
                string fullName = name + " " + userInput;
                Console.WriteLine(fullName);
            }
            //Step 4- Create a second loop that prints off each string in the array one at a time
            for(int i = 0; i < stringArray.Length; i++)
            Console.ReadLine();

            //ASSIGNMENT PART TWO
            //Step 1- Add an infinite loop
            bool value = true;
            while (value = true)
            {
                Console.WriteLine("Hello, World");
                Console.ReadLine();
                value = false;
                //Step 3- fix the infinite loop so it stops printing after 1
                break;




                

            }
        }
    }
}
