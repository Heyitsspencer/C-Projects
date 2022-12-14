using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    //Step 1-Create a class
    class UserInput
    {
        
        //Step 1- Create a void method that outputs an integer
        public void DoMathOperation(int p1)
        {
            //Step 1- have the method divide the data passed to it by 2
            //Display the output to the screen
            Console.WriteLine(p1 / 2);
            Console.ReadLine();
        }
        //Step 4- Create a method with output parameters
        public void Add100(int p1, out int p2, out int p3)
        {
            p2 = 100 + p1;
            p3 = 100 + p2;
        }
        //Step 5- Overload a method
        public void DoMathOperation(int p1, int p2)
        {
            Console.WriteLine(p1 * p2);
            Console.ReadLine();
        }
    }
}
