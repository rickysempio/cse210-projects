using System.Data.SqlTypes;
using System.Runtime.InteropServices;

public class Order
{
    private List<Product> _products;

    private int _shippingCost;

    public  Order()
    {
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in _products)
        {
            totalPrice += product.GetPrice() * product.GetQuantity();
        }
        return totalPrice + ShippingCost();
    }

    public void DisplayItems()
    {
        Console.WriteLine("Customer Packing Labels:");
        Console.WriteLine("Products ordered:");
        foreach(var product in _products)
        {
            Console.WriteLine($"Product:{product.GetProductName()}, Product ID:{product.GetProductID()}, Price:{product.GetPrice()}, Product Quantity:{product.GetQuantity()}");
            
        }
    }

    public int ShippingCost()
    {
        if (Address.IsAddressInUSA() == true)
            {
                _shippingCost = 5;
            }
        else 
            {
                _shippingCost = 35;
            }
        return _shippingCost;
    }

    public string DisplayShippingLabel()
    {
        return "";
    }
}
