public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string CustomerName
    {
        get { return _name; }
    }

    public string CustomerAddress
    {
        get { return _address.DisplayAddress(); }
    }

    public bool LivesInUSA()
    {
        return _address.IsInAmerica();
    }
}