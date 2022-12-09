using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Spencer";
            //string quote = "The man said, \" Hello\", Spencer.";

            //Console.WriteLine(quote);
            //Console.ReadLine();

            //string name = "Spencer";
            //name = "joe";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Spencer");


            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
