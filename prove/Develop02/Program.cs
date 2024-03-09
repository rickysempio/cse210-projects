using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();

        while(true)
        {   
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");

            Console.Write("What Would you like to do? ");
            //Console.WriteLine(">");

            string input = Console.ReadLine();

            if (input == "1")
                journal.AddEntry();
            
        

            else if (input == "2")
                journal.Displayall();

            else if (input == "3")
            {
                Console.WriteLine("Filename: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }

            else if (input == "4")
            {
                Console.WriteLine("Filename: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }

            else if (input == "5")
            {
                break;
            }
            else
                Console.WriteLine("Invalid input");

        }
    }
}