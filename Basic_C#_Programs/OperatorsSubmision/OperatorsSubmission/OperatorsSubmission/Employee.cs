using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Employee
    {
        //Step 1- Create an Employee class with Id, FirstName and LastName properties. 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Step 2- In the Employee class, overload the “==” operator so it checks if two
        //Employee objects are equal by comparing their Id property. Remember that
        //comparison operators must be overloaded in pairs.
        public override bool Equals(object obj)
        {
            Employee employee2 = (Employee)obj;
            if (Id == employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Equals(employee2);
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !employee1.Equals(employee2);
        }
    }
}
