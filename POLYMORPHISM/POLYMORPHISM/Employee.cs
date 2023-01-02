using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Employee: ");
            base.SayName();
        }
        //My Employee class inherits the interface
        //and implements the Quit() method 
        public void Quit()
        {
            Console.WriteLine("\nCurrent satic: \nHas quit");
        }
    }
}