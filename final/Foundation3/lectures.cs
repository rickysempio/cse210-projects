using System.Diagnostics.Tracing;

public class Lectures : Event
{
    private string  _speakerName;
    private int _capacity;


    public Lectures(string type, string title, string description, string date, string time, string speakerName, int capacity) : base(type, title, description, date, time)
    {
        _speakerName = speakerName;
        _capacity = capacity;  
  
    } 

    public void SetSpeakerName(string speakerName)
    {
        _speakerName = speakerName;
    }

    public string GetSpeakerName()
    {
        return _speakerName;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }


    public int GetCapacity()
    {
        return _capacity;
    }


    public string LecturesEventDetails()
    {
        return $"Speaker Name: {_speakerName}, Capacity: {_capacity}";
    }
}