using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Please press Enter to start.");
            Console.ReadLine();

            //Person 1 info
            Console.WriteLine("Person 1");

            //Person 1 hourly rate
            Console.WriteLine("What is your hourly rate?");
            string payRate = Console.ReadLine();
            decimal payRate1 = Convert.ToInt32(payRate); //converting decimal to int
            Console.WriteLine("your hourly rate is " + payRate1);
            Console.ReadLine();

            //Person 1 hours worked this week
            Console.WriteLine("How many hours did you work this week?");
            string hours = Console.ReadLine();
            decimal hours1 = Convert.ToInt32(hours);
            //int numTotal = Console.ReadLine();
            Console.WriteLine("You worked this week " + hours1 + " hours!");
            Console.ReadLine();

            //Annual salary for Person 1
            Console.WriteLine("Weekly salary for Person 1");
            decimal salaryOne = payRate1 * hours1;
            Console.WriteLine(salaryOne);
            decimal monthlyWage = salaryOne * 4; //created a months worth of pay
            Console.WriteLine("annual salary of person 1 is " + salaryOne * 52); //mutliply by 52 weeks in a year
            Console.ReadLine();

            //Person 2 info
            Console.WriteLine("Person 2");

            //Person 2 hourly rate
            Console.WriteLine("What is your hourly rate?");
            string payRate2 = Console.ReadLine();
            decimal payRate22 = Convert.ToInt32(payRate2);
            Console.WriteLine("your hourly rate is " + payRate22);
            Console.ReadLine();

            //Person 2 how many hours did you work this week
            Console.WriteLine("How many hours did you work this week?");
            string hours2 = Console.ReadLine();
            decimal hours22 = Convert.ToInt32(hours2);
            Console.WriteLine("This week you Worked " + hours22 + " hours!");
            Console.ReadLine();


            //Annual salary for person 2 
            Console.WriteLine("Weekly salary for Person 2");
            decimal salaryTwo = payRate22 * hours22;
            Console.WriteLine(salaryTwo);
            decimal monthlyWages = salaryTwo * 4;
            Console.WriteLine("annual salary of person 2 is " + salaryTwo * 52); //mutliply by 52 weeks in a year
            Console.ReadLine();

            //Does person 1 make more money than person 2?
            Console.WriteLine("Does Person 1 make more money than person 2?");
            bool greaterThan = salaryOne > salaryTwo;
            Console.WriteLine("Person 1 makes more than Person 2: " + greaterThan);
            Console.ReadLine();


        }
    }
}