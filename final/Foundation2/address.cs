using System.Reflection;

public class Address
{
    private string _streetAddress;
    private string _theCity;
    private string _stateProvince;
    private string _country;


    public static bool _isAddressInUSA;

    public Address(string streetAdress, string theCity, string stateProvince, string country)
    {
        _streetAddress = streetAdress;
        _theCity = theCity;
        _stateProvince = stateProvince;
        _country = country;
    }

    public Address()
    {

    }


    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;

    }

    public void SetTheCity(string theCity)
    {
        _theCity = theCity;
    }

    public string GetTheCity()
    {
        return _theCity;

    }

    public void SetStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }

    public string GetStateProvince()
    {
        return _stateProvince;
    }


    public void SetCountry(string country)
    {
        _country = country;

    }

    public string GetCounry()
    {
        return _country;

    }

    public void SetIsAddressInUSA(bool isAddressInUSA)
    {
        _isAddressInUSA = isAddressInUSA;
    }

    public bool GetIsAddressInUSA()
    {
        return _isAddressInUSA;
    }

    public static bool IsAddressInUSA()
    {
        return _isAddressInUSA = true;
    }

    public string DisplayAddressDetails()
    {
        return $"Customer Address:{_streetAddress}, {_theCity}, {_stateProvince}, {_country}";
    }
}
