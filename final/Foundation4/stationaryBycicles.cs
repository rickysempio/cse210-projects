public class Cycling : Activity
{


    public Cycling(string date, int lenght, double distance, double speed, double pace) : base(date, lenght, distance, speed, pace)
    {
        
    }

    public override double Distance()
    {
        return  _distance = (_speed * _lenght ) / 60;
    }

    
    public override double Speed()
    {
        return _speed = (_distance / _lenght) / 60;
    }

    public override double Pace()
    {
        return  _pace = _lenght / _distance;
    }



    public override string  GetSummary()
    {
        return $"{_date} Cycling ({_lenght} min): Distance {_distance} km, Speed {Math.Round(_speed, 2)} kph, Pace:{_pace} min per km";
    }

}