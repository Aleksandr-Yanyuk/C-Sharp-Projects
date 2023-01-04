using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates new DateTime object
            DateTime now = DateTime.Now;

            //shows only time of DateTime
            Console.WriteLine(now.ToString("hh:mm tt"));
            Console.WriteLine("Please enter a number.");
            //Converts user input to data type of double
            Double x = Convert.ToDouble(Console.ReadLine());
            //adds user input to current time, instantiating it to later
            DateTime later = DateTime.Now.AddHours(x);
            //writes only the time of the DateTime added from user input
            Console.WriteLine(later.ToString("hh:mm tt"));
            Console.ReadLine();
        }
    }
}