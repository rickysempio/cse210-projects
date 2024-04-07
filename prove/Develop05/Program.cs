using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager(0);

        string userChoice = "";

        while(userChoice != "6")
        {
            Console.WriteLine($"You have 0 goal");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5  Record events");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the Menu :");
            userChoice = Console.ReadLine();
            

            if (userChoice == "1")
            {
                Console.WriteLine("Create new goals");
                gm.CreateGoal();
            }

            else if (userChoice == "2")
            {
                Console.WriteLine("List goals");

            

            }

            else if (userChoice == "3")
            {
                Console.WriteLine("Save goals");
            }

            else if (userChoice == "4")
            {
                Console.WriteLine("Load goals");
            }

            else if (userChoice == "5")
            {
                Console.WriteLine("record events");
            }

            else if (userChoice == "6")
            {
                Console.WriteLine("quit");
            }

            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}