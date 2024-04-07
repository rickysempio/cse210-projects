using System.Reflection;

public class Customer
{
    private string  _customerName;

    private Address _address;


    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public Customer(string customerName)
    {
        _customerName = customerName;
    }

    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }


    public void SetCustomerAdress(Address address)
    {
        _address = address;
    }

    public Address GetCustomerAddress()
    {
        return _address;
    }

    public bool IsUSA()
    {
        return Address.IsAddressInUSA();
    
    }

    public string DisplayCustomerName()
    {
        Console.WriteLine("Customer Shipping Details:");
        return $"Customer Name: {_customerName}";
    }

    public string DisplayCustomerShippingDetails()
    {
        Console.WriteLine("Customer Shipping Details:");
        return $"Customer Name:{_customerName}, Address:{_address}";
    

    }

}