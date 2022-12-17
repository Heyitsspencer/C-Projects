using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 5- Inside the Main() method, instantiate an Employee object
            //with firstName “Sample” and lastName “Student”.

            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };
            //Call the SayName() method on the object.
           employee.SayName();

        }
    }
}
