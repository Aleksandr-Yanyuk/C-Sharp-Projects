using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //one-dimensional Array of strings. Ask the user to select an index of the Array

                Console.WriteLine("Select an index from 0 to 4. \nThen, The Magic begins!.");
                string[] stringArray = { "shark", "dog", "lion", "bobcat", "catfish" };
                int string1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The value of that index is: " + stringArray[string1]);
                Console.ReadLine();



                Console.WriteLine("Select an index from 0 to 4. \nThen, WHAT WILL YOU PICK?.");
                int[] numArray = { 5, 21, 19, 86, 12 };
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("The value of that index is: " + numArray[input]);
                Console.ReadLine();

                Console.WriteLine("Select an index from 0 to 3. \nThen, I will show you a trick!.");
                List<string> list1 = new List<string>() { "Alex", "Mr bean", "borat", "chuck norris" };
                int list2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The value of that index is: " + list1[list2]);
                Console.ReadLine();

            }

            catch (System.IndexOutOfRangeException)

            {
                //message that displays when the user selects an index that doesn’t exist.

                Console.WriteLine("Selected index does not exist.");
            }

            Console.ReadLine();

        }
    }
}