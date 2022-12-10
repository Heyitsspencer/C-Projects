using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
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
                stringArray[name] = stringArray[name] + userInput;
            }
            Console.WriteLine(stringArray[1]);
            Console.ReadLine();

        }
    }
}
