public abstract class Activity
{
    protected string _date;
    protected int _lenght; // in minutes

    protected double _distance;
    protected double _speed; // minutes per mile or minutes per kilometer
    protected double _pace; // minutes per mile or minute per kilometer


    public Activity (string date, int lenght, double distance, double speed, double pace)
    {
        _date = date;
        _lenght = lenght;
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }

    public string GetDate()
    {
        return _date;
    }


    public void SetDate(string date)
    {
        _date = date;
    }
    
    public int GetLenght()
    {
        return _lenght;
    }


    public void SetLenght(int lenght)
    {
        _lenght = lenght;
    }


    public double GetDistance()
    {
        return _distance;
    }


    public void SetDistance(int distance)
    {
        _distance = distance;
    }

    public double GetPace()
    {
        return _pace;
    }


    public void SetPace(double pace)
    {
        _pace = pace;
    }
    

    public virtual double Distance()
    {
        return _distance;
    }

    public virtual double Speed()
    {
        return _speed;
    }

    public virtual double Pace()
    {
        return _pace;
    }


    public abstract string GetSummary();

}