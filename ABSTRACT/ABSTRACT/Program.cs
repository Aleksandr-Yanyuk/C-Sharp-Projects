using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside the Main() method, instantiated an Employee object with
            //firstName “Sample” and lastName “Student”. Call the SayName() method on the object.
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.ReadLine();
        }
    }
}