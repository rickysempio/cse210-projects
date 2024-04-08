public class OutdoorGatherings : Event
{
    private string _statementOfWeather;


    public OutdoorGatherings(string type, string title, string description, string date, string time,string statementOfWeather) : base(type, title, description, date, time)
    {
        _statementOfWeather = statementOfWeather;
    }


    public void SetStatementOfWeather(string statementOfWeather)
    {
        _statementOfWeather = statementOfWeather;
    }

    public string GetStatementOfWeather()
    {
        return _statementOfWeather;
    }


    public string StatementOfWeather()
    {
        return _statementOfWeather;
    }
}