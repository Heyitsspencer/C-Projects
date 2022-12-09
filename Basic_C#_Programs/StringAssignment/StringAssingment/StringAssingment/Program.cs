using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssingment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Spencer";
            string dateString = DateTime.Today.ToShortDateString();
            string question = "How are you today?";

            //Concatenate 3 strings together
            string str = "Hello " + firstName + ". Today is " + dateString + ". " + question;
            //Converts string to uppercase
            string upperstr = str.ToUpper();
            Console.WriteLine(upperstr);
            Console.ReadLine();
            //Create a stringbuilder that expects to hold 50 characters
            //Initialize the stringbuilder with "ABC"
            StringBuilder sb = new StringBuilder("ABC", 50);

            //Append three characters (D, E, and F) to the end of the StringBuilder
            sb.Append(new char[] { 'D', 'E', 'F' });

            //Append a format string to the end of the StringBuilder
            sb.AppendFormat("GHI{0}{1}", 'J', 'K');

            //Display the number of characters in the StringBuilder and its string
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
            Console.ReadLine();

            //
        }
    }
}
