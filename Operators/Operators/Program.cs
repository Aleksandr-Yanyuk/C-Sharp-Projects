using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> sampleEmployee = new Employee<string>();
            sampleEmployee.FirstName = "Sample";
            sampleEmployee.LastName = "Student";
            sampleEmployee.Id = 007;
            sampleEmployee.things = new List<string>() { "Boost Software", "Downpipes", "Turbo", "Supercharger", "Intakes" };
            sampleEmployee.SayName();
            Console.WriteLine("Employee ID: " + Convert.ToString(sampleEmployee.Id));
            Console.WriteLine("First Employee's Request to make a highly boosted car!:");
            foreach (string tool in sampleEmployee.things)
            {
                Console.WriteLine(tool);
            }

            Employee<string> employeeTwo = new Employee<string>();
            employeeTwo.Id = 700;
            bool sameIDs = employeeTwo == sampleEmployee;
            Console.WriteLine("sampleEmployee and employeeTwo have identical IDs: " + Convert.ToString(sameIDs));
            Employee<int> employeeThree = new Employee<int>();
            employeeThree.things = new List<int>() { 1, 7, 4 };
            Console.WriteLine("Employee Three's List of Favorite Numbers:");
            foreach (int num in employeeThree.things)
            {
                Console.WriteLine(Convert.ToString(num));
            }

            sampleEmployee.Quit();

            IQuittable quitTime = new Employee<double>();

            Console.WriteLine("Hope you enjoyed your stay here with this program...");
            quitTime.Quit();

        }
    }
}