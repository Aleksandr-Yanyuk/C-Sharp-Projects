using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parsing_enums
    {
        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Please enter current day of the week.");
                    string entry = Console.ReadLine();
                    //parses through DaysOfWeek and string entry compares for a match
                    DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), entry);
                    Console.WriteLine(day);

                }
                //Invalid entry
                catch (Exception)
                {

                    Console.WriteLine("Please enter the actual day of the week.");
                }

                Console.ReadLine();

            }
            public enum DaysOfWeek //Create an enum for the days of the week.
        {
                Sunday,
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday
        }
        }
    }