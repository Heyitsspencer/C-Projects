using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndCompOpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            //Person 1- Step 2
            Console.WriteLine("Person 1 \n Enter your hourly rate: ");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Enter your hours worked this week: ");
            string hoursWorked1 = Console.ReadLine();
            //Person 2- Step 3
            Console.WriteLine("Person 2 \n Enter your hourly rate: ");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Enter your hours worked this week: ");
            string hoursWorked2 = Console.ReadLine();
            //Converts strings to int
            int hourlyRateInt1 = Convert.ToInt32(hourlyRate1);
            int hourlyRateInt2 = Convert.ToInt32(hourlyRate2);
            int hoursWorkedInt1 = Convert.ToInt32(hoursWorked1);
            int hoursWorkedInt2 = Convert.ToInt32(hoursWorked2);
            //Person 1 total- Step 4
            int total1 = hourlyRateInt1 * hoursWorkedInt1 * 52;
            Console.WriteLine("Annual Salary of Person 1: $" + total1 );
            Console.ReadLine();
            //Person 2 total- Step 5
            int total2 = hourlyRateInt2 * hoursWorkedInt2 * 52;
            Console.WriteLine("Annual Salary of Person 2: $" + total2);
            Console.ReadLine();
            //Step 6
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            string trueOrFalse = Console.ReadLine();
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();

        }
    }
}
