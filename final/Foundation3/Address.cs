public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string DisplayAddress()
    {
        string address = $"Address: {_street}";
        string city = $"City: {_city}";
        string state = $"State/Province: {_state}";
        string country = $"Country: {_country}";

        return $"{address}\n{city}\n{state}\n{country}";
    }
}