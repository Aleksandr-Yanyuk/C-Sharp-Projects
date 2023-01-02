using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiated 2 new employee objects
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            emp1.Id = 1;
            emp2.Id = 2;

            //compared id of employees
            Console.WriteLine(emp1 == emp2);
            Console.ReadLine();
        }
    }
}