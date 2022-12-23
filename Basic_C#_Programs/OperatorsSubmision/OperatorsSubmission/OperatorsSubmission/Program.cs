using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 3- In the "Program.cs" file, instantiate two objects of the Employee
            //class and assign values to their properties. Then compare the two Employee
            //objects using the newly overloaded operators and display the results.
            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Spencer",
                LastName = "Davis"
            };

            Employee employee1 = new Employee
            {
                Id = 2,
                FirstName = "Steven",
                LastName = "Tolbert"
            };

            if (employee == employee1)
            {
                Console.WriteLine("Employee is equal to Employee1");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee is not equal to Employee1");
                Console.ReadLine();
            }

            // Change ID to test
            employee1.Id = 1;
            if (employee == employee1)
            {
                Console.WriteLine("Employee is equal to Employee1");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee is not equal to Employee1");
                Console.ReadLine();
            }
        }
    }
}
