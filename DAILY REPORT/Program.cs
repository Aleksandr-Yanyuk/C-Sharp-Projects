using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Daily_Report_Tech_Academy
{
    class Program
    {
        static void Main()
        {
            //asking the console to write with the writeline the two strings.
            Console.WriteLine("the tech academy");
            Console.WriteLine("student daily report");
            //console asking what your name is

            //console question for your name.
            Console.WriteLine("what is your name?");
            string yourname = Console.ReadLine();
            Console.WriteLine("hello" + " " + yourname);
            //console reading answers and storing


            //requesting input of current course.
            Console.WriteLine("what course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("you currently are on course " + course);


            //requesting input of page number currently on.
            Console.WriteLine("what page number are you on:?");
            string pagenum = Console.ReadLine();
            int pagenumber = Convert.ToInt32(pagenum);//perfroms a caste conversion string to int
            Console.WriteLine("you are currently on page number " + pagenumber);


            //requesting input of help needed? boolian would be done to perform the data type statement returning true or false



            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool helpIsNeeded = Convert.ToBoolean(Console.ReadLine());


            //if statement
            if (helpIsNeeded == true)
            {
                Console.WriteLine("Student needs help! "); //returns our boolean statement as true help is needed
                                                           //Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Student does not need help! "); //returns boolean statement as false does not need help
                Console.ReadLine();

            }



            //requesting input of possitive expierences
            Console.WriteLine("Were there any posistive experiences you'd like to share? Please give specific.");
            string experience = Console.ReadLine();
            Console.WriteLine("Thank you for your submission of positive experiences: " + experience);

            //requesting input of feedback to your instructor
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback! " + feedback);


            //requesting input of hrs study
            Console.WriteLine("How many hours did you study today?");
            string hoursStudys = Console.ReadLine();
            //int hoursStudy = Console.ReadLine();
            Console.WriteLine("Hours study " + hoursStudys);

            //int hoursStudy =  Console.ReadLine();
            //string final = ("today your studies accounts for" + hoursStudy);
            // Console.WriteLine(final);
            //Console.ReadLine("Great job, Today your total study hours are" + hoursStudy);


            //console stating that an instructor will get back to you shortly!
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great Day!");
            Console.ReadLine();
            //end of program.

        }
    }
}