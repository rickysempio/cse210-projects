using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine();


        Running running = new Running("05 Mar 2024", 30, 100, 50, 20);
        running.Distance();
        running.Speed();
        running.Pace();
        Console.WriteLine(running.GetSummary());


        Cycling cycling= new Cycling("05 Mar 2024", 30, 200, 100, 40);
        cycling.Distance();
        cycling.Speed();
        cycling.Pace();
        Console.WriteLine(cycling.GetSummary());


        Swimming swimming = new Swimming("05 Mar 2024", 30, 75, 25, 15, 50);
        swimming.Distance();
        swimming.Speed();
        swimming.Pace();
        Console.WriteLine(swimming.GetSummary());
        Console.WriteLine();


        Console.WriteLine($"Running Distance : {Math.Round(running.Distance(), 2)} km");
        Console.WriteLine($"Cycling Speed : {Math.Round(cycling.Speed(), 2)} kph");
        Console.WriteLine($"Swimming Number of Laps : {swimming._numberOfLaps} laps");
        Console.WriteLine();


    }
}