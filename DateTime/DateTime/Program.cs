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
            DateTime current = DateTime.Now;//declaring our DateTime 
            Console.WriteLine("At this moment in time, it is: " + current);
            Console.WriteLine("Enter a number: ");
            string userNum = Console.ReadLine();//users input gets converted to a user string
            int userInt = Convert.ToInt32(userNum);//userInt gets converted to int32
            DateTime futureTime = current.AddHours(userInt);//this gives us current time

            Console.WriteLine("In " + userInt + " hours, it will be " + futureTime);//math equation to get users time and date adds the users input from the first question, returns future time specified by you. date and time + fututre time.
            Console.ReadLine();
        }
    }
}