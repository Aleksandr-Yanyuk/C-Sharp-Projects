using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CALLING_METHODS

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number, this program will do a muliplication, addition, and Finally Dividing the number you entered. .");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number that you typed will be now multiplied by 162, Your answer : ");

            Maths multi = new Maths();
            multi.Multi(number);
            Console.ReadLine();

            Console.WriteLine("The number you entered plus 55, Programs answer : ");

            Maths add = new Maths();
            add.Adding(number);
            Console.ReadLine();

            Console.WriteLine("Your number divided by 4 equal  : ");

            Maths divi = new Maths();
            divi.Divide(number);
            Console.ReadLine();
        }
    }
}