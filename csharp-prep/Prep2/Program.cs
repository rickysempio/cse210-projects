using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int letterGrade = int.Parse(grade);
        string letter = "";
        
        if (letterGrade >= 90)
        {
            //Console.WriteLine("A");
            letter = "A";
        }
        else if (letterGrade >= 80)
        {
            //Console.WriteLine("B");
            letter = "B";
        }
        else if (letterGrade >= 70)
        {
            //Console.WriteLine("C");
            letter = "C";
        }
        else if (letterGrade >= 60)
        {
            //Console.WriteLine("D");
            letter = "D";
        }
        else
        {
            letter = "F";
        }   

            Console.WriteLine($"Your grade is {letter}");    
        

        if (letterGrade >= 70)
        {
            Console.WriteLine("Congratulations you Pass!");
        }

        else 
        {
            Console.WriteLine("You did not pass!, study hard..."); 
        }     
    }   
}