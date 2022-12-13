using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    //Step 1- Create a class
    class UserInput
    {
        //Step 1- In that class, create a method that will take in an integer,
        //Create a math operation for this integer, then return the answer as an integer.
        public int DoMathOperation(int p1)
        {
            return p1 + 100;
        }
        //Step 3- add a second method to the class with the same name that will take in a decimal,
        //create a different math operation for it and then return the answer as an 
        public int DoMathOperation(decimal p1)
        {
            return (int)(p1 / 2.6M);
        }
        //Step 5- Add a third method to the class, with the same name, that will take in a string, convert it to an
        //integer if possible, do a different math operation to it, then return the answer as an integer.
        public int DoMathOperation (string p1)
        {
            if (int.TryParse(p1, out int value))
            {
                return value * 200;
            }
            else
            {
                throw new InvalidOperationException("Invalid Input");
            }
        }
    }
}
