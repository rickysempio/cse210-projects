using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");


        Fraction myFraction = new Fraction();
        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetDecimalValue());
        


        Fraction myFraction2 = new Fraction(5);
        Console.WriteLine(myFraction2.GetFractionString());
        Console.WriteLine(myFraction2.GetDecimalValue());
            

        Fraction myFraction3 = new Fraction(3, 4);
        Console.WriteLine(myFraction3.GetFractionString());
        Console.WriteLine(myFraction3.GetDecimalValue());


        Fraction myFraction4 = new Fraction(1, 3);
        Console.WriteLine(myFraction4.GetFractionString());
        Console.WriteLine(myFraction4.GetDecimalValue());
        
    }
}
