public class Event
{
    protected string _title;
    protected string _description;
    protected string _eventType;
    protected Address _address;
    protected string _date;
    protected string _time;

    public Event(string title, string desc, Address address, string date, string time)
    {
        _title = title;
        _description = desc;
        _address = address;
        _date = date;
        _time = time;
    }

    public string DisplayStandardMessage()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\n{_address.DisplayAddress()}";
    }

    public string DisplayShortMessage()
    {
        return $"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}";
    }

    public void DisplayEventDetails()
    {
        Console.WriteLine("Standard Event Details:");
        Console.WriteLine(DisplayStandardMessage());
        Console.WriteLine();
        Console.WriteLine("Short Event Description:");
        Console.WriteLine(DisplayShortMessage());
    }
}