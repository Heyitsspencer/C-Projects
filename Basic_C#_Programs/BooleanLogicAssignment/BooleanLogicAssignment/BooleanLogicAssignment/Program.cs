using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1
            Console.WriteLine("What is your age? ");
            string age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age); //Converts age to integer
            Console.WriteLine("Have you ever had a DUI? True/False ");
            string dui = Console.ReadLine();
            bool duiBool = Convert.ToBoolean(dui);
            Console.WriteLine("How many speeding tickets do you have? ");
            string tickets = Console.ReadLine();
            int ticketsInt = Convert.ToInt32(tickets);//Converts tickets to integer
            //Step 2
            bool canBuyInsurance = (ageInt >= 15 && duiBool == false && ticketsInt < 3);
            Console.WriteLine("Can you buy Insurance? " + canBuyInsurance);
            Console.ReadLine();
            
        }
    }
}
