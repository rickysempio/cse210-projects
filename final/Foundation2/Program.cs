using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine();


        Product product1 = new Product("Laptop", 1234, 1200, 2);
        Product product2 = new Product("Handphone",2345, 800, 3);
        Product product3 = new Product("Speaker", 3453, 200, 2);

        Order order = new Order();
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);
        Console.WriteLine();


        order.DisplayItems();
        Console.WriteLine();
        double totalPrice = order.TotalPrice();
        Console.WriteLine($"Total Price of order: ${totalPrice}");
        Console.WriteLine($"Shipping Cost: ${order.ShippingCost()}");

        Console.WriteLine();

        
             
        //Customer customer = new Customer("Michael", new Address("13th street", "Los Angeles","Califorania","USA"));
        //Console.WriteLine($"{customer.DisplayCustomerShippingDetails()}");

    
        Customer customer = new Customer("Bryan Adams");
        Console.WriteLine(customer.DisplayCustomerName());
        

        Address address = new Address();
        address.SetStreetAddress("13th street");
        address.SetTheCity("California");
        address.SetStateProvince("California");
        address.SetCountry("USA");
        Console.WriteLine($"{address.DisplayAddressDetails()}");
        address.SetIsAddressInUSA(true);

        
        Console.WriteLine();


        Product product4 = new Product("Desktop PC", 7894, 1800, 3);
        Product product5 = new Product("Projector",2345, 800, 2);
        Product product6 = new Product("Wireless Modem", 3773, 400, 2);

        Order order1 = new Order();
        order1.AddProduct(product4);
        order1.AddProduct(product5);
        order1.AddProduct(product6);
        Console.WriteLine();
        

        order1.DisplayItems();
        Console.WriteLine();
        totalPrice = order1.TotalPrice();
        Console.WriteLine($"Total Price of order: ${totalPrice}");
        Console.WriteLine($"Shipping Cost: ${order1.ShippingCost()}");

        Console.WriteLine();

        
             
        //Customer customer2 = new Customer("John", new Address("123th street", "San Diego","Califorania","USA"));
        //Console.WriteLine($"{customer2.DisplayCustomerShippingDetails()}");

        Customer customer2 = new Customer("John Michael");
        Console.WriteLine(customer2.DisplayCustomerName());
        

        Address address2 = new Address();
        address2.SetStreetAddress("123th street");
        address2.SetTheCity("San Diego");
        address2.SetStateProvince("California");
        address2.SetCountry("USA");
        Console.WriteLine($"{address2.DisplayAddressDetails()}");
        address2.SetIsAddressInUSA(true);
        Console.WriteLine();
 

    }
}