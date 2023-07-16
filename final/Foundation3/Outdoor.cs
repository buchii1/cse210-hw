public class Outdoor : Event
{
    private string _weatherInfo;

    public Outdoor(string title, string desc, Address address, string date, string time, string weather) : base(title, desc, address, date, time)
    {
        _weatherInfo = weather;
        _eventType = "Outdoor Gatherings";
    }

    public string DisplayFullDetails()
    {
        string text = base.DisplayStandardMessage();
        return $"{text}\nEvent Type: {_eventType}\nWeather Info: {_weatherInfo}";
    }

    public void DisplayEvent()
    {
        base.DisplayEventDetails();
        Console.WriteLine();
        Console.WriteLine("Full Event Details:");
        Console.WriteLine(DisplayFullDetails());
    }
}