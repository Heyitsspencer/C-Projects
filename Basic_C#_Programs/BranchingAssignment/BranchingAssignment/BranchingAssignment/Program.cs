using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please Follow the instructions below. \n Please enter your package weight: ");//Step 1 and step 2
            int packageWeight = Convert.ToInt32(Console.ReadLine()); //Converts user input to integer
            while (true) //Creates a loop that is able to be 'broken out of'.
            {
                if (packageWeight > 50)//Step 3
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                    break; //Breaks out of while loop. Ends program after next user event
                }
                Console.WriteLine("Please enter your package width:"); //Step 4
                int packageWidth = Convert.ToInt32(Console.ReadLine());////Converts user input to integer

                Console.WriteLine("Please enter your package height:"); //Step 5
                int packageHeight = Convert.ToInt32(Console.ReadLine());////Converts user input to integer

                Console.WriteLine("Please enter your package length:"); //Step 6
                int packageLength = Convert.ToInt32(Console.ReadLine());////Converts user input to integer

                int totalDimensions = packageWidth + packageHeight + packageLength; //Adds all dimenstions together to get a total
                
                    if (totalDimensions > 50) //Determines if dimensions are larger than 50
                    {
                        Console.WriteLine("Package too big to be shipped via Package Express.");// Step 7
                        Console.ReadLine();
                        break; //Breaks out of while loop, ends program after next user event
                    }
                int quote = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100; //Creates a quote for the user- Step 8
                Console.WriteLine("Your quote is: $" + quote); //Step 1000 display the quote as a dollar amount to the user
            }
        }
    }
}
