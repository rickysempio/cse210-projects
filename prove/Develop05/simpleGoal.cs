using System.Collections.Concurrent;
using System.Dynamic;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
    }

    public override void  RecordEvent()
    {
        _isComplete = true;
    }

    public override bool isComplete()
    {
            return _isComplete;
    }


    public override string GetDetailsString()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        //Console.WriteLine("The goals are :");
        return $"[ ] {_shortName} ({ _description})";
    }

}