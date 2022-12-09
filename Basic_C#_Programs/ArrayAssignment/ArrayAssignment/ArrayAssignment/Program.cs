using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Mirabelle", "Goose", "Pigeon", "Murphy", "Scotty", "Yogi" }; //Creates string array
            Console.WriteLine("Select an index of the Animal Array"); //Has user enter input 
            int selectedStringIndex = Convert.ToInt32(Console.ReadLine());//Saves user input into variable and converts it to integer
            if (selectedStringIndex <= 6)
            {
                Console.WriteLine("The animal at that index is: " + stringArray[selectedStringIndex]); //Prints users input if equal to or less than 6 
                Console.ReadLine(); //Allows user to read program output
            }
          
            //Displays an error message if index user selected doesn't exist
            else if (selectedStringIndex > 6)
            {
                Console.WriteLine("That index does not exist.");
                Console.ReadLine();
            }

            int[] intArray = { 1, 2, 3, 4, 5, 6 }; //Creates integer array
            Console.WriteLine("Select an index of the Number Array"); //Has user enter input 
            int selectedIntIndex = Convert.ToInt32(Console.ReadLine());//Saves user input into variable and converts it to integer
            if (selectedIntIndex <= 6)
            {
                Console.WriteLine("The number at that index is: " + intArray[selectedIntIndex]); //Prints users input if equal to or less than 6 
                Console.ReadLine(); //Allows user to read program output
            }

            //Displays an error message if index user selected doesn't exist
            else if (selectedStringIndex > 6)
            {
                Console.WriteLine("That index does not exist.");
                Console.ReadLine();
            }
        }
    }
}
