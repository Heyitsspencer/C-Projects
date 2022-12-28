using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2- In the Main() method, create an object of data type Number
            //and assign an amount to it.
            Number number = new Number();
            number.Amount = 10;

            //Step 3- Print this amount to the console.
            Console.WriteLine("The number is " + number.Amount);
            Console.ReadLine();
        }
    }
}
