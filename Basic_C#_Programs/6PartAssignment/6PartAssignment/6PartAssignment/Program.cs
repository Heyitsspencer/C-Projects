using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASSIGNMENT PART ONE 
            //Step 1- Add a one dimensional array of strings
            string[] stringArray = { "Mirabelle", "Goose", "Pigeon", "Diamond", "Ollie", "Harley" };
            //Step 2- Asks the user to input text
            Console.WriteLine("Enter your last name: ");
            //Saves user input into variable
            string userInput = Console.ReadLine();
            //Step 3- A loop that iterates through each string in the array and adds the user's text input 
            // to the end of each string 
            for(int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + " " + userInput;
            }
            //Step 4- Create a second loop that prints off each string in the array one at a time
            for(int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            

            //ASSIGNMENT PART TWO
            //Step 1- Add an infinite loop
            while (true)
            {
                Console.WriteLine("Hello, World");
                Console.ReadLine();
                //Step 3- fix the infinite loop so it stops printing after 1
                break;
            }

            //ASSIGNMENT PART THREE
            //Step 1- A loop where the comparison that's being used to determine
            //whether to continue iterating the loop is a < operator
            int[] intArray = { 22, 45, 76, 11, 89, 95 };
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);

            }
            //Step 2- another loop where the comparison that’s used to determine whether
            //to continue iterating the loop is a “<=” operator
            int[] intArray1 = { 2, 5, 6, 1, 8, 9 };
            int counter = 0;
            while (counter <= 5)
            {
                Console.WriteLine(intArray1[counter]);

 
                counter++;
                
            }
            Console.ReadLine();

            //ASSIGNMENT PART FOUR
            //Step 1- add a list of strings where each item in the list is unique
            List<string> stringList = new List<string>();
            stringList.Add("Spencer");
            stringList.Add("Steven");
            stringList.Add("Aaron");
            stringList.Add("Shannon");
            stringList.Add("Erin");
            //Step 2- asks the user to input text to search for in the list
            Console.WriteLine("Enter a name to search in the list: ");
            string userNameInput = Console.ReadLine();
            //Step 3- a loop that iterates through the list and then displays the index
            //of the list item that contains matching text on the screen.
            bool found = false;
            for (int k = 0; k < stringList.Count; k++)
            {
                if(userNameInput == stringList[k])
                {
                    Console.WriteLine(k);
                    Console.ReadLine();
                    found = true;
                    //Step 5- Add code that stops the loop from executing once a match has been found.
                    break;
                }
            }
            //Step 4- Add code to check if the user put in text that isn't on the list
            //and, if they did, tell the user their input is not on the list. 
            if (!found)
            {
                Console.WriteLine("Your input is not on the list");
                Console.ReadLine();
            }



        }
    }
}
