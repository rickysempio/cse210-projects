using System;
using System.Formats.Asn1;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)   
    {
        Console.WriteLine("Hello Develop04 World!");

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. quit");
        
        Console.WriteLine("Select choice from the menu:");

        string userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            Activity _breathing = new("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
            
            _breathing.DisplayStartingMessage();

            Console.Write("How long, in seconds, would you like for your session? ");
            string  countdown = Console.ReadLine();

            Console.WriteLine("Get ready...");

            

            int seconds = int.Parse(countdown);

            
        



            






        }

        else if (userChoice == "2")
        {

        }
        else if (userChoice == "3")
        {
        
        }

        else if (userChoice == "4")
        {

        }
            
        
    
    }   
}