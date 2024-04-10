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


    public string GetShortName()
    {
        return _shortName;
    }

    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
        
    }



    public abstract void RecordEvent();
    

    public abstract bool IsComplete();
    
    
    public virtual string GetDetailsString()
    {
        return ""; 
    }


    public abstract string GetStringRepresentation();

    //public virtual void SetNameDescriptionPoints()
    //{
        //Console.WriteLine("What is the name of your goal? "); 
        //_shortName = Console.ReadLine();

       // Console.WriteLine("What is the description? ");
        //_description = Console.ReadLine();

        //Console.WriteLine($"what is the amount of points associated with this goal");
        //_points = int.Parse(Console.ReadLine());
    //}

    
}