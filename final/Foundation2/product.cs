public class Product
{
    protected string _productName;
    protected int _productID;

    protected int  _quantity;
    protected double _price;


    public Product(string productName, int productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _quantity = quantity;
        _price = price;

    }
    
    public void SetProductName(string productName)
    {
        _productName = productName;
    }
    
    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductID(int productID)
    {
        _productID = productID;
    }

    public int GetProductID()
    {
        return _productID;
    }


    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }


    public void SetPrice(double price)
    {
        _price = price;
    }

    public double GetPrice()
    {
        return _price;
    }
}