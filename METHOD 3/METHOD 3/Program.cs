using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiated 
            ClassMethod Formula = new ClassMethod();

            // Asked for user input of one integer with the option for a second integer.
            Console.WriteLine("Please type an integer you would like to performed on");
            int firstInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you would like a second integer to be a part of the, type it here and press \"Enter.\" " +
                "\n If you are fine with just one integer and have no other integer,! 'or\n just press \"Enter\" without input.");



            bool ifInteger = Int32.TryParse(Console.ReadLine(), out int secondInput);

            // Called the "Calc" method, allowing for one or two separate integers.
            if (ifInteger == true)
            {
                Console.WriteLine("now your integers have become: " + ClassMethod.Calc(firstInput, secondInput) + "!");
            }
            else
            {
                Console.WriteLine("now your integer has become: " + ClassMethod.Calc(firstInput, secondInput) + "!");
            }

            Console.ReadLine();

            //STEP Tried several integer combinations, as well as only inputting one integer, 
        }
    }
}