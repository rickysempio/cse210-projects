using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
    
        
        //Console.Write("What is the magic number?");
        //string number = Console.ReadLine();
        //int magicNumber = int.Parse(number);

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);
        
        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess ?");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
        
            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }

            else if  (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }

            else 
            {
            Console.WriteLine("you guessed it right!");
            }

        }
    }


    
}