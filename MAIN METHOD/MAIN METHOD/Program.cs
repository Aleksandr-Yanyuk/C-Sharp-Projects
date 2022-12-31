using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD

    {

        class Program
        {
            public static void Main(string[] args)
            {
                Maths method1 = new Maths(); //instantiating class maths
                                        
                Console.WriteLine("Method that takes an int and returns an int and adds 5: " + method1.one_method(12));//preset values

                Console.WriteLine("Method that takes an decimal and returns an int and adds 10: " + method1.one_method(1.22m));

                Console.WriteLine("Method that takes an string and returns an int and adds 20: " + method1.one_method("12"));

                Console.Read();

            }

            public class SampleOne
            {
                public void IntergerMethod(int num)
                {
                    Decimal newValue = Convert.ToDecimal(num);
                    Console.WriteLine(newValue);
                    Console.ReadLine();
                }

            }
        }
    }
