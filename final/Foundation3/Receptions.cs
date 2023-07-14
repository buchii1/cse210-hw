public class Receptions : Event
{
    private string _emailMessage;

    public Receptions(string title, string desc, Address address, string date, string time, string email) : base(title, desc, address, date, time)
    {
        _emailMessage = email;
        _eventType = "Receptions";
    }

    public string DisplayFullDetails()
    {
        string text = base.DisplayStandardMessage();
        return $"{text}\nEvent Type: {_eventType}\nEmail: {_emailMessage}";
    }

    public void DisplayEvent()
    {
        base.DisplayEventDetails();
        Console.WriteLine();
        Console.WriteLine("Full Event Details:");
        Console.WriteLine(DisplayFullDetails());
    }
}