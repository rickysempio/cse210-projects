using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");


        Scripture scripture = new(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        

        while (true)
        {
            Console.Clear();
            scripture.GetDisplayText();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

                if (input.ToLower()  == "quit")
                    break;

                scripture.HideRandomWords( 3 );

                if (scripture.IsCompletelyHidden())
                    break;
        
        }       
    }
}