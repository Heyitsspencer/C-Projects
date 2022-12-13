using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2- In the Main() method of the console app, instantiate the class.
            UserInput userInput = new UserInput();
            //Step 3- Ask the user to input two numbers, one at a time.
            Console.WriteLine("Enter a number: ");
            string numberInput1 = Console.ReadLine();
            //Step 3- Let them know they need not enter anything for the second number.
            Console.WriteLine("Enter another number (if you want): ");
            string numberInput2 = Console.ReadLine();

            //Step 4-Call the method in the class, passing in the one or two numbers entered
            if (numberInput2 != "")
            {
                int doMathOperation = userInput.DoMathOperation(Convert.ToInt32(numberInput1), Convert.ToInt32(numberInput2));
                Console.WriteLine(numberInput1 + " + " + numberInput2 + " = " + doMathOperation);
            }
            else
            {
                int doMathOperation = userInput.DoMathOperation(Convert.ToInt32(numberInput1));
                Console.WriteLine(numberInput1 + " + 0  = " + doMathOperation);
            }
            Console.ReadLine();
        }
    }
}
