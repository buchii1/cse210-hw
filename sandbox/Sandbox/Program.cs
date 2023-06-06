using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sandbox");
    }
}

public class Menu
{
    private List<string> _prompts = new List<string>();


    public void DisplayPrompts()
    {

    }
}

public class Activity
{
    private string _name;
    private string _description;
    private string _duration;

    public Activity(string name, string description, string duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void StartMessage()
    {

    }

    public void EndMessage()
    {

    }

    public void Spinner()
    {

    }
}

public class Breathing : Activity
{
    private int interval;
    public Breathing(string name, string description, string duration) : base(name, description, duration)
    {

    }

    public void CountDown()
    {

    }
}

public class Reflection : Activity
{
    public Reflection()
    {
        // Add constructors
    }

    private List<string> _prompts;
    private List<string> _followUpPrompts;

    public string DisplayRandomPrompt()
    {
        return "a randomly selected prompt";
    }

    public string DisplayFollowUpPrompt()
    {
        return "a randomly selected follow up prompt";
    }
}

public class Listing : Activity
{
    private List<string> _prompts;
    private int _counter;

    public string DisplayRandomPrompt()
    {
        return "a randomly selected prompt";
    }
}