using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();

            //Using polymorphism to create an object of type IQuittable
            //and call the Quit() method on it. 
            IQuittable quit = new Employee();
            quit.Quit();

            Console.ReadLine();
        }
    }
}