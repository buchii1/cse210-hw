using System;

public class Entry
{
    public string _userResponse;
    public string _date;
    public string _question;

    public Entry ()
    {
        // Get the current date
        DateTime now = DateTime.Now;
        _date = now.ToString("MM/dd/yyyy HH:mm tt");
    }

    public void GetEntry(string userResponse, string question)
    {
        _userResponse = userResponse;
        _question = question;
    }
    

    public void DisplayEntry()
    {   
        Console.WriteLine($"Date: {_date} - Prompt: {_question}\n{_userResponse}");
        Console.WriteLine();
    }
}