using System.Collections.Concurrent;

public class EternalGoal : Goal

//private bool _isComplete;

{
    private bool _isComplete;

    public EternalGoal(string shortName, string description, int points) : base (shortName, description, points)
    {

    }

    public override void RecordEvent()
    {
        _isComplete = true;

    }

    //public override string GetDetailsString()
    //{
        //return "";
    //}

    public override bool IsComplete()
    {
        return _isComplete = false;
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {_shortName} ({ _description})";
    }

}