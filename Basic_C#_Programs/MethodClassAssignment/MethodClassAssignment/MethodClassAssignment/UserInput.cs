using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    //Step 1- Create a class
    class UserInput
    {
        //Step 1- create a void method that takes two integers as parameters
        public void DoMathOperation(int p1, int p2)
        {
            //Have the method do a math operation on the first integer
            //and display the second integer to the screen.
            int value = p1 + 100;
            Console.WriteLine(value);
            Console.WriteLine(p2);
        }

    }
}
