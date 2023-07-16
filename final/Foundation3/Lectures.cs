public class Lectures : Event
{
    private string _speakerName;
    private int _capacity;

    public Lectures(string title, string desc, Address address, string date, string time, string speaker, int capacity) : base(title, desc, address, date, time)
    {
        _speakerName = speaker;
        _capacity = capacity;
        _eventType = "Lectures";
    }

    public string DisplayFullDetails()
    {
        string text = base.DisplayStandardMessage();
        return $"{text}\nEvent Type: {_eventType}\nSpeaker Name: {_speakerName}\nCapacity: {_capacity}";
    }

    public void DisplayEvent()
    {
        base.DisplayEventDetails();
        Console.WriteLine();
        Console.WriteLine("Full Event Details:");
        Console.WriteLine(DisplayFullDetails());
    }
}