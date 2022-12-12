using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Step 1- Create a class
namespace CallingMethods
{
    public class UserInput
    {
        //Step 1- Create three methods, each of which that take one integer parameter in and return one integer
        //These should do some math application on the received parameter.
        public int Squared(int p1)
        {
            return p1 * p1;
        }

        public int Add100(int p1)
        {
            return 100 + p1;
        }

        public int Subtract10(int p1)
        {
            return p1 - 10;
        }

    }
}
