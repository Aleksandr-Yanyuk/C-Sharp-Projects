using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODSANDOBJECTS
{
    class Person
    {
        public Person(string fn = "", string ln = "")
        {
            FirstName = fn;
            LastName = ln;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}