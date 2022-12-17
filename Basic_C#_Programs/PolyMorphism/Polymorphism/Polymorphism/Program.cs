using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 3- Use polymorphism to create an object of type
            //IQuittable and call the Quit() method on it
            IQuittable employee = new Employee();
            employee.Quit();
        }
    }
}
