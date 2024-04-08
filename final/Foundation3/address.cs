public class Address : Event
{
    public string _address;


    public Address(string type, string title, string description, string date, string time, string address) : base(type, title, description, date, time)
    {
        _address = address;
    }

    public void SetAddress(string address)
    { 
        _address = address; 
    }

    public string GetAddress()
    {
        return _address;
    }



    public string EventAddress()
    {
        return $"Event Address: {_address}";
    }
}