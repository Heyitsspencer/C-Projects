using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && false);//AND
            Console.WriteLine(true || true);//OR
            Console.WriteLine(true == true);//EQUAL
            Console.WriteLine(true != true);//NOT EQUAL
            Console.WriteLine(true ^ true);//Will evaluate to true if one but not both are true
            `



            Console.ReadLine();
        }
    }
}
