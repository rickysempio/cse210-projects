using System.Runtime.CompilerServices;

public class Event
{
    protected string  _typesOfEvents;

    protected string _title;

    protected string _description;
    protected string _date;

    protected string _time;


    public Event (string type, string title, string description, string date, string time)
    {
        _typesOfEvents = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }

    public void SetTypeOfEvents(string type)
    {
        _typesOfEvents = type;
    }

    public string GetTypeOfEvents()
    {
        return _typesOfEvents;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle(string title)
    {
        return _title;
    }


    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetTime(string time)
    {
        _time = time;
    }

    public string GetTime()
    {
        return _time;
    }


    public string StandardDetails()
    {  
        return $"Event Title: {_title}, Description:{_description}, Date: {_date}, Time: {_time}";
    }

    public string FullDetails()
    {
        Console.WriteLine("Event Full Details:");
        Console.WriteLine(StandardDetails());
        return $"Type of Events:{_typesOfEvents}";
        
    }

    public string ShortDescription()
    {
        Console.WriteLine("Events Short Description:");
        return $"Type of Events: {_typesOfEvents}, Title: {_title}, Date: {_date}";
    }
}