using System.ComponentModel;
using System.Drawing;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points; 


    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    

    public abstract bool isComplete();
    
    
    public abstract string GetDetailsString();


    public abstract string GetStringRepresentation();

    public virtual void SetNameDescriptionPoints()
    {
        Console.WriteLine("What is the name of your goal? "); 
        _shortName = Console.ReadLine();

        Console.WriteLine("What is the description? ");
        _description = Console.ReadLine();

        Console.WriteLine($"what is the amount of points associated with this goal");
        _points = int.Parse(Console.ReadLine());
    }
    
    
}