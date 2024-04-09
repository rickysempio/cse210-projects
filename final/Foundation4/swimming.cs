public class Swimming : Activity
{

    public int _numberOfLaps;



    public Swimming(string date, int lenght, double distance, double speed, double pace,int numberOfLaps ) : base(date, lenght, distance, speed, pace)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double Distance()
    {
       return  _distance = ((_numberOfLaps * 50 / 1000) * _lenght ) / 60;
    }   
        
    public override double Speed()  
    {  
        return _speed = _distance / _lenght * 0.62;

    }

    public override double Pace()
    {
        return _pace = _lenght / (_numberOfLaps * 50 / 1000);
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_lenght} min): Distance {_distance} km, Speed {Math.Round(_speed, 2)} kph, Pace:{_pace} min per km";
    }




}