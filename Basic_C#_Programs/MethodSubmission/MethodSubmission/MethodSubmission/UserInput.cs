using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MethodSubmission
{
    //Step 1- Create a class.
    class UserInput
    {
        //Step 1- Create a method that takes two integers as parameters.
        //Make one of them optional.
        //Have the method do a math operation and return an integer result.
        public int DoMathOperation(int p1, int p2 = 0)
        {
            return p1 + p2;
        }
    }
}
