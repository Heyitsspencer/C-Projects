using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2- In the Main() method, create a list of at least 10 employees.
            //At least two employees should have the first name “Joe”.
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee(1, "Spencer", "Davis"));
            employees.Add(new Employee(2, "Steven", "Tolbert"));
            employees.Add(new Employee(3, "Shannon", "Cerny"));
            employees.Add(new Employee(4, "Aaron", "Cerny"));
            employees.Add(new Employee(5, "Erin", "McMichael"));
            employees.Add(new Employee(6, "Joe", "Mama"));
            employees.Add(new Employee(7, "Mark", "McMichael"));
            employees.Add(new Employee(8, "Michelle", "McMichael"));
            employees.Add(new Employee(9, "Joe", "Smith"));
            employees.Add(new Employee(10, "Erin", "Schuman"));


            //Step 3- Using a foreach loop, create a new list of all employees with the
            //first name “Joe”. In your comparison statement, remember to reference the
            //property of the object you are checking.
            Console.WriteLine("Showing all Joes.");
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    List<Employee> JoeList = new List<Employee>();
                    JoeList.Add(employee);
                    Console.WriteLine(employee.FirstName);
                    Console.ReadLine();
                }
                
            }

            //Step 4- Perform the same action again, but this time with a lambda expression.
            Console.WriteLine("Showing all Joes with lambda.");
            List<Employee> allJoes = employees.FindAll(x => x.FirstName == "Joe");
            foreach (Employee employee1 in allJoes)
            {
                Console.WriteLine(employee1.FirstName);
                Console.ReadLine();
            }

            //Step 5- Using a lambda expression, make a list of all employees with an
            //Id number greater than 5.
            Console.WriteLine("Showing all ID > 5.");
            List<Employee> greaterThan5 = employees.FindAll(x => x.Id > 5);
            foreach (Employee employee2 in greaterThan5)
            {
                Console.WriteLine(employee2.FirstName + "," + employee2.Id);
                Console.ReadLine();
            }
        }
    }
}
