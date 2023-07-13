public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateOrder()
    {
        double totalCost = 0;

        foreach (Product item in _products)
        {
            totalCost += item.ProductPrice();
        }

        return totalCost += ShippingCost();
    }

    public int ShippingCost()
    {
        int shippingFee = 0;
        
        if (_customer.LivesInUSA())
        {
            shippingFee = 5;
        }
        else
        {
            shippingFee = 35;
        }

        return shippingFee;
    }

    public void PackingLabel()
    {
        int i = 1;

        Console.WriteLine("Order Details:");
        foreach (Product item in _products)
        {
            Console.WriteLine($"{i}. {item.ProductName} - {item.ProductId}");
            i++;
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("Customer Info:");
        Console.WriteLine($"Name: {_customer.CustomerName}");
        Console.WriteLine(_customer.CustomerAddress);
    }
}