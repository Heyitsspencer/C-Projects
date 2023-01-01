using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1- Asks the user for a number.
            Console.WriteLine("Please enter a number: ");
            //Saves user input into variable
            string userNumber = Console.ReadLine();
            //Step 2- Logs that number to a text file.
            using (StreamWriter file = new StreamWriter(@"C:\Users\mmcmi\OneDrive\Documents\School\C-Sharp-Projects\Basic_C#_Programs\InputAssignment\Log\log.txt", true))
            {
                file.WriteLine(userNumber);
            }
            //Step 3- Prints the text file back to the user.
            Console.WriteLine("Your number is {0}", userNumber);
            Console.ReadLine();
        }
    }
}
