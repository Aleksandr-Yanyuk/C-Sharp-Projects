using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();

            //instanties new list object as employees
            List<Employee> employees = new List<Employee>()
            {
                //creates new employees with their Id, FirstName, and LastName
                new Employee() { Id = 1, FirstName = "Joe", LastName = "Kutcher" },
                new Employee() { Id = 2, FirstName = "Joe", LastName = "Winslet" },
                new Employee() { Id = 3, FirstName = "Levaeh", LastName = "williams" },
                new Employee() { Id = 4, FirstName = "Adeline", LastName = "Farrow" },
                new Employee() { Id = 5, FirstName = "Buddy ", LastName = "Lawson" },
                new Employee() { Id = 6, FirstName = "Satchel ", LastName = "Sirius" },
                new Employee() { Id = 7, FirstName = "Diezel ", LastName = "Lazslo" },
                new Employee() { Id = 8, FirstName = "Bronx ", LastName = "Reign" },
                new Employee() { Id = 9, FirstName = "Cherry ", LastName = "Owen" },
                new Employee() { Id = 10, FirstName = "Mustard ", LastName = "Christensen" }
            };

            //Creates new list for the Joes wanted
            List<Employee> listOfJoes = new List<Employee>();

            //creates employee variable of employees
            foreach (Employee employee in employees)
            {
                //if "Joe" is found in employee
                if (employee.FirstName == "Joe")
                {
                    //add "Joe" to listOfJoes
                    listOfJoes.Add(employee);
                }

            }
            //iterates through list of joes
            foreach (Employee joe in listOfJoes)
            {
                //writes joes
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }
            Console.ReadLine();

            //goes through list of employees and adds to listOfJoes2,
            //if the name "Joe" is found in employees
            List<Employee> listOfJoes2 = employees.Where(n => n.FirstName == "Joe").ToList();
            foreach (Employee joe2 in listOfJoes2)
            {
                Console.WriteLine(joe2.FirstName + " " + joe2.LastName);
            }
            Console.ReadLine();

            //iterates through empId, finds Id's over 5
            //adds those over 5 to idOver5
            List<Employee> idOver5 = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee id in idOver5)
            {
                Console.WriteLine(id.Id + " " + id.FirstName);
            }

            Console.ReadLine();
        }
    }
}
