using System.Collections.Concurrent;

public  class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus ;
    private bool _iscomplete;


    public ChecklistGoal(string shortName, string description, int points, int bonus) : base(shortName, description, points)
    {
    

    }
    
    public override void RecordEvent()
    {
        _iscomplete = true;
    }

    public override bool IsComplete()
    {
        return _iscomplete = false;
    }

    public override string  GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {_shortName} ({ _description})";
    }

}