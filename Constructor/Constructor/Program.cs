using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a variable that cannot be changed
            const string learntoday = "learntoday";
            //using var to create a variable, var implicitly detects what the value is
            var x = 777;

            //person1 uses overloaded constructor with defualt parameter for age
            People person1 = new People("Alex");

            //person2 uses original constructor with two parameters
            People person2 = new People("Natalie", 36);
            Console.WriteLine("{0} is {1} years old, while {2} is {3} years old.", person1.name, person1.age, person2.name, person2.age);
            Console.ReadLine();
        }
        //creating new class
        public class People
        {
            public string name;
            public int age;

            //chaining constructors 
            //inherits from other People constructor but defaults age to 34
            public People(string name) : this(name, 34)
            {

            }
            public People(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
    }
}
