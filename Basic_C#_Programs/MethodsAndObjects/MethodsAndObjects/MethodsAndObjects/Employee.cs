using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    //Step 3- Create another class called Employee and have it inherit from the Person class.
    class Employee : Person
    {
        //Step 3- Give the Employee class a property called Id and have it be of data type int.
        public int Id { get; set; }
    }
}
