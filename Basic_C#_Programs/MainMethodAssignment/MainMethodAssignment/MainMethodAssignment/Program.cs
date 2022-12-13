using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2- Instantiate the class and call the one method, passing in an integer
            UserInput userInput = new UserInput();
            int doMathOperation = userInput.DoMathOperation(55);
            //Step 2- Display the result to the screen
            Console.WriteLine("55 + 100 = " + doMathOperation);
            Console.ReadLine();

            //Step 4- instantiate the class and call the second method, passing in a decimal
            //Display the result to the screen
            UserInput userInput2 = new UserInput();
            int doMathOperation2 = userInput.DoMathOperation(25.7M);
            Console.WriteLine("25.7 / 2.6 = " + doMathOperation2 + " (Rounded)" );
            Console.ReadLine();

            //In the Main() method of the console app, instantiate the class and call the third method,
            //passing in a string that equates to an integer. Display the result to the screen.

            UserInput userInput3 = new UserInput();
            int doMathOperations3 = userInput.DoMathOperation("17");
            Console.WriteLine("17 * 200 = " + doMathOperations3);
            Console.ReadLine();


        }
    }
}
