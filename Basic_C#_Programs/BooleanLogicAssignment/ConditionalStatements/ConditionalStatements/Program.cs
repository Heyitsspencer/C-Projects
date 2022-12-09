using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Spencer";
            if (name == "Steven")
            {
                Console.WriteLine("Your name is Steven");
            }
            else if (name == "Shannon")
            {
                Console.WriteLine("Your name is not Steven");
            }
            else if (name == "Aaron")
                Console.WriteLine("Your name is Aaron");
        }
    }
}
