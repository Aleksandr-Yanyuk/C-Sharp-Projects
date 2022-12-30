using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP_STRINGS_AND_INTEGERS

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 10, 8, 6 };
                Console.WriteLine("Please enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                int divide;

                foreach (int items in numbers)
                {
                    divide = items / number;
                    Console.WriteLine(divide);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}