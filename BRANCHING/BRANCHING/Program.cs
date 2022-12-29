using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRANCHING

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");


            Console.WriteLine("Please enter package weight");
            string weight = Console.ReadLine();
            int packageWeight = Convert.ToInt32(weight);


            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();

            }

            Console.WriteLine("Please enter package width");
            string width = Console.ReadLine();
            int packageWidth = Convert.ToInt32(width);


            Console.WriteLine("Please enter package height");
            string height = Console.ReadLine();
            int packageHeight = Convert.ToInt32(height);


            Console.WriteLine("Please enter package length");
            string length = Console.ReadLine();
            int packageLength = Convert.ToInt32(length);


            if (packageHeight + packageLength + packageWidth > 50)
            {
                Console.WriteLine("If the package weight is over 50 or if the total dimensions are over 50 package too is big to be shipped via Package Express.");
                Console.ReadLine();

            }

            decimal sum = packageWeight * (packageHeight * packageLength * packageWidth) / 100m;
            Console.WriteLine("Your estimated total for shipping this package is: $" + sum);
            Console.ReadLine();
        }
    }
}