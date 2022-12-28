using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2- Prompt the user to enter the current day of the week.
            Console.WriteLine("Please enter the current day of the week:");
            string userInput = Console.ReadLine();
            //Step 3- Assign the value to a variable of that enum data type you just created.

            //Step 4- Wrap the above statement in a try/catch block and have it print
            //"Please enter an actual day of the week.” to the console if an error occurs.
            try
            {
                DaysOfTheWeek daysOfTheWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
                Console.WriteLine("You entered: " + daysOfTheWeek.ToString());
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
    }
}
