using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT
{
    //Created another class called Employee and had it inherit from the Person class.
    public class Employee : Person
    {
        //Implemented the SayName() method inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine("Employee: ");
            base.SayName();
        }


    }
}