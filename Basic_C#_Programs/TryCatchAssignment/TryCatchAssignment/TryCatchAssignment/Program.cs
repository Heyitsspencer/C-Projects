using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1- Ask the user for their age.
            try
            {
                Console.WriteLine("Please enter your age");
                int usersAge = Convert.ToInt32(Console.ReadLine());
                //Step 4- Display appropriate error messages if the user enters zero
                //or negative numbers.
                if (usersAge <= 0)
                {
                    Console.WriteLine("Please enter a number greater than zero.");
                    Console.ReadLine();
                }
                else
                {
                    //Determines year of birth
                    int usersBirthYear = 2023 - usersAge;

                    //Step 2-Display the year the user was born
                    //Step 3- Handle exceptions using "try/catch".

                    Console.WriteLine("You were born in the year {0}.", usersBirthYear);
                    Console.ReadLine();
                }

            }
            catch (Exception)
            {
                //Step 5- Display a general message if an exception was caused by anything else.
                Console.WriteLine("An error occured, please contact your system admin.");
                Console.ReadLine();
            }
        }
    }
}
