using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2- In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("What number do you want to do math operations on?");
            int input = Convert.ToInt32(Console.ReadLine());
            UserInput userInput = new UserInput();
            
            //Step 3- Call each method in turn, passing the user input to the method.
            int add100 = userInput.Add100(input);
            int squared = userInput.Squared(input);
            int subtract10 = userInput.Subtract10(input);

            //Display the returned integer to the screen.
            Console.WriteLine(input + " plus 100 equals " + add100);
            Console.WriteLine(input + " squared equals " + squared);
            Console.WriteLine(input + " minus 10 equals " + subtract10);

            Console.ReadLine();
        }
    }
}
