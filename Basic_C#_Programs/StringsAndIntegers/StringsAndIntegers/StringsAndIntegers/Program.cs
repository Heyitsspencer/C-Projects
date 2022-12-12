using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1- Create a list of integers
            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
            intList.Add(50);
            intList.Add(60);
            
            //Step 5- Put the loop in a try/catch blocl
            try
            {
                //Step 1- Ask the user for a number to divide each number in the list by.
                Console.WriteLine("Enter a number to divide each number in the list by.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                //Step 1- Write a loop that takes each integer in the list, divides it by the
                //number the user entered, and displays the result to the screen.
                foreach (int number1 in intList)
                {
                    Console.WriteLine(number1 + " divided by " + userInput + " is equal to " + number1 / userInput);
                    Console.ReadLine();
                }
            }
            //Error message for if the user types in a 0
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero");
            }
            //Error message for if the user types in string
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            //Error message for other unforseen errors
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Step 5
            Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution.");
            Console.ReadLine();
            
        }
    }
}
