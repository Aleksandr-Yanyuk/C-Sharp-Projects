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
            Console.ReadLine();

            Console.WriteLine("Please enter package weight");
            string weight = Console.ReadLine();
            int packageWeight = Convert.ToInt32(weight);


            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(1);
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
            Console.ReadLine();

            if (packageHeight + packageLength + packageWidth > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(1);
            }

            decimal sum = packageWeight * (packageHeight * packageLength * packageWidth) / 100m;
            Console.WriteLine("Your estimated total for shipping this package is: $" + sum);
            Console.ReadLine();
        }
    }
}