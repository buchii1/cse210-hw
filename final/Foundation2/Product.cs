public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productId = productID;
        _price = price;
        _quantity = quantity;
    }

    public string ProductName
    {
        get => _name;
    }

    public int ProductId
    {
        get => _productId;
    }

    public double ProductPrice()
    {
        return _price *= _quantity;
    }
}