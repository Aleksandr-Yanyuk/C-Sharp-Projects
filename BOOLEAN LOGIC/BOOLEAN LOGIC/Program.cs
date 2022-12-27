using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BOOLEAN_LOGIC

{
    class Program
    {
        static void Main(string[] args)
        {
            // What is your age
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageOne = Convert.ToInt32(age);

            //Has the client had a Dui Before
            //requesting input of help needed? boolian would be done to perform the data type statement returning true or false
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\"");
            bool Dui = Convert.ToBoolean(Console.ReadLine());


            //if statement
            if (Dui == true)
            {
                Console.WriteLine("Has DUI's! "); //returns our boolean statement as true help is needed
            }
            else
            {
                Console.WriteLine("clean RECORD!! "); //returns boolean statement as false does not need help
            }

            // How many speeding tickets has a client obtained
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int speedingTickets = Convert.ToInt32(tickets);


            if (ageOne > 15 && !Dui && speedingTickets <= 3)
            {
                Console.WriteLine("You are qualified");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("You are not qualified");
                Console.ReadLine();
            }
        }
    }
}