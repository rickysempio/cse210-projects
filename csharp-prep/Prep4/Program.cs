using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();

        int number = -1;  

        while (number != 0)
        {
            Console.Write("Enter a list of number, type 0 when finished :");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numbers.Add(number);
        
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;

        }

        Console.WriteLine($"The total is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The Average is {average}");

        
        int max = 0;

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }

        }
        Console.WriteLine($"The max number is {max}");
    }


}