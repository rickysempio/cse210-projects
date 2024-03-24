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
            Activity _breathing = new("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
            
            _breathing.DisplayStartingMessage();

            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session? ");
            string  countdown = Console.ReadLine();

            Console.WriteLine("Get ready...");
            _breathing.ShowSpinner(5);

            Console.WriteLine();
            Console.Write("Breathe in...");
            _breathing.ShowCountDown(4);

            Console.WriteLine();
            Console.Write("Now breathe out...");
            _breathing.ShowCountDown(5);

            Console.WriteLine();
            Console.Write("Now breathe in...");
            _breathing.ShowCountDown(4);

            Console.WriteLine();
            Console.Write("Now breathe out...");
            _breathing.ShowCountDown(5);

            //int seconds = int.Parse(countdown);
            _breathing.ShowSpinner(5);

            _breathing.DisplayEndingMessage();
         

        }

        else if (userChoice == "2")
        {
            Activity _reflecting = new("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

            _reflecting.DisplayStartingMessage();

            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            string  countdown = Console.ReadLine();

            Console.WriteLine("Get ready...");
            _reflecting.ShowSpinner(5);

            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine("---Think of a time when you stood up for someone else.---");
            Console.WriteLine();
            Console.WriteLine("When you have someting in mind press enter to continue...");
            _reflecting.ShowSpinner(5);
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
            Console.Write("you may begin in...");


            _reflecting.ShowCountDown(4);

            Console.WriteLine("> How did you feel when it was complete?");
            _reflecting.ShowSpinner(8);

            Console.WriteLine("> What is your favorite thing about this assignment?");
            _reflecting.ShowSpinner(5);
      
            Console.WriteLine();
            _reflecting.DisplayEndingMessage();
            _reflecting.ShowSpinner(5);

        }

        else if (userChoice == "3")
        {
            Activity _listing = new("Listing Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

            _listing.DisplayStartingMessage();

            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            string  countdown = Console.ReadLine();

            Console.WriteLine("Get ready...");
            _listing.ShowSpinner(5);

            Console.WriteLine();
            Console.WriteLine("List as many responses to the following prompt:");

            Console.WriteLine("---Who are people that you appreciate?---");
            Console.Write("you may begin in:");
            _listing.ShowCountDown(5);

            Console.Write(">");
            Console.ReadLine();

            Console.Write(">");
            Console.ReadLine();

            Console.Write(">");
            Console.ReadLine();

            Console.Write(">");
            Console.ReadLine();
            
            Console.WriteLine();
            _listing.DisplayEndingMessage();


        }

        else if (userChoice == "4")
        {
            
        }
            
        
    
    }   
}