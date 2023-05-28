using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
    }
}

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // A method that displays the reference
    public string GetReference() {
       string reference;

       if (_endVerse != null)
       {
            reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
       }
       else
       {
            reference = $"{_book} {_chapter}:{_verse}";
       }

       return reference;
    }
}