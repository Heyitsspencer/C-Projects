using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2- In the Main() method of the console app, instantiate the class.
            UserInput userInput = new UserInput();
            //Step 3- Call the method in the class, passing in two numbers.
            userInput.DoMathOperation(250, 338);
            //Step 4- Call the method in the class, specifying the parameters by name.
            userInput.DoMathOperation(p1: 250, p2: 338);

        }
    }
}
