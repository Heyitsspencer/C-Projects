using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2- In the Main() method, instantiate that class
            UserInput userInput = new UserInput();
            //Step 3- Have the user enter a number.
            Console.WriteLine("Please enter a number to divide by two");
            int number = Convert.ToInt32(Console.ReadLine());
            //Step 3- Call the method on that number.

            userInput.DoMathOperation(number);

        }
    }
}
