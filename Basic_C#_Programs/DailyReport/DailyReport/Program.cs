using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \n Student Daily Report"); //Prints header
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.ReadLine(); //Allows user to read output
            Console.WriteLine("What is the date?"); //Asks for user input
            string todaysDate = Console.ReadLine(); //Saves input in string format so it can be read by user
            Console.WriteLine("What course are you on");
            string todaysCourse = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string todaysPageNumber = Console.ReadLine();
            int todaysPageNumber1;
            todaysPageNumber1 = Convert.ToInt32(todaysPageNumber);
            Console.WriteLine("Do you need help with anything? Answer \"True\" or \"False\"");
            string helpNeeded = Console.ReadLine();
            bool helpNeeded1;
            helpNeeded1 = Convert.ToBoolean(helpNeeded);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string todaysPositives = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string todaysFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string todaysHours = Console.ReadLine();
            int todaysHours1;
            todaysHours1 = Convert.ToInt32(todaysHours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
