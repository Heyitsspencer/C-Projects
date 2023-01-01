using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1- Prints the current date and time to the console.
            Console.WriteLine("The current time is: " + DateTime.Now);

            //Step 2- Asks the user for a number.
            Console.WriteLine("Please enter a number.");
            //Saves the user input into a variable
            string userInput = Console.ReadLine();
            double userInputDouble = Convert.ToDouble(userInput);
            //Step 3- Prints to the console the exact time it will be in X hours,
            //X being the number the user entered in step 2.
            DateTime newTime = DateTime.Now.AddHours(userInputDouble);
            Console.WriteLine("In {0} hours, it will be {1}.", userInput, newTime);
            Console.ReadLine();

        }
    }
}
