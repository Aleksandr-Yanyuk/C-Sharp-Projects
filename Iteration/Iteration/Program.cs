using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Iteration

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] groceryList = { "", "", "", "", "", "" };
            Console.WriteLine("Please type below 6 things you need to buy at the grocery: ");
            for (int g = 0; g < 6; g++)
            {
                groceryList[g] = (g + 1) + ". " + Console.ReadLine();
            }

            Console.WriteLine("\nThank you. Here is the list that you have provided: \n");
            for (int g = 0; g < 6; g++)
            {
                Console.WriteLine(groceryList[g]);
            }

            Console.WriteLine("\nThank you for the list. Now please pick an even number between 1 and 100.");

            int evenNumber = 0;

            while (!int.TryParse(Console.ReadLine(), out evenNumber))
            {
                Console.WriteLine("I think you didn't enter a number.");
                Console.WriteLine("Please pick an even number between 1 and 100.");
            }

            while (evenNumber > 100 || evenNumber < 1)
            {
                Console.WriteLine("Please try again. Pick a number between 1 and 100.");

                while (!int.TryParse(Console.ReadLine(), out evenNumber))
                {
                    Console.WriteLine("I think you didn't enter a number.");
                    Console.WriteLine("Please pick a number between 1 and 100.");
                }
            }

            Console.WriteLine("You should have picked number 100. Now it's going to print forever in an endless loop!\n");

            for (int g = 0; g > evenNumber; g++)
            {
                Console.WriteLine(evenNumber);
            }

            for (int g = 0; g < evenNumber; g++)
            {
                Console.WriteLine(evenNumber + "" + (g + 1));
            }
            Console.WriteLine("No it's not an endless loop. I am just wasting your time.");
            Console.ReadLine();

            for (int g = 1; g <= evenNumber; g++)
            {
                Console.WriteLine(evenNumber + "" + (g));
            }

            Console.WriteLine("I am just wasting your time.");

            List<string> foodList = new List<string>();
            string[] foods = { "sushi", "sashimi", "karage", "ramen", "soba" };
            foodList.AddRange(foods);

            foreach (string food in foodList)
            {
                Console.WriteLine(food);
            }

            Console.WriteLine("Please type one of the foods listed above.");
            string searchFood = Console.ReadLine();

            foreach (string food in foodList)
            {
                if (searchFood == food)
                {
                    Console.WriteLine(searchFood + " is at index value: " + foodList.IndexOf(food));
                }
                if (!foodList.Contains(searchFood))
                {
                    Console.WriteLine("That's not on the list. Please try again.");
                    searchFood = Console.ReadLine();
                }
            }

            List<string> secondFoodList = new List<string>();
            string[] foodsAgain = { "Siomai", "Siopao", "Lomi", "Pansit", "Goto", "Siomai", "Pansit", "Lomi" };
            secondFoodList.AddRange(foodsAgain);

            foreach (string food in secondFoodList)
            {
                Console.WriteLine(food);
            }

            Console.WriteLine("\nWe have another list of foods here. Type in one of them to see how many indices it appears in.");
            searchFood = Console.ReadLine();
            int i = 0;

            foreach (string food in secondFoodList)
            {
                if (searchFood == food)
                {
                 Console.WriteLine("It looks like " + searchFood + " appeared in that index " + i + " Yummy.\n");
                 Console.ReadLine();
                }
                i++;
            }

            if (!secondFoodList.Contains(searchFood))
            {
                Console.WriteLine("That's not in the list. Please try again.");
                searchFood = Console.ReadLine();
            }




            List<string> drinksList = new List<string>();
            string[] drinks = { "Boba Milk Tea", "Green Tea", "Soda", "Milk", "Beer", "Green Tea", "Soda" };
            drinksList.AddRange(drinks);
            foreach (string drink in drinksList)
            {
                Console.WriteLine(drink);
            }
            Console.WriteLine("\nHere's a list of drinks, let's see what the duplicates are.\n");

            int d = 0;
            List<string> checkList = new List<string>();



            foreach (string drink in drinksList)
            {
                if (checkList.Contains(drink))
                {
                    Console.WriteLine(drink + " has already appeared on this list!");
                    d++;
                }
                if (!checkList.Contains(drink))
                {
                    Console.WriteLine(drink + " has not yet appeared on this list!");
                    checkList.Add(drink);
                }

            }

            Console.WriteLine("Looks like there were " + d + " duplicates in there.");

            Console.ReadLine();

        }


    }
}