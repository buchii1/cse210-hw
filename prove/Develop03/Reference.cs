// A code template for the category of things known as Reference.
// The responsibility of a Reference is to hold and display scripture reference    
public class Reference
{
    private string  _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;


    // A constructor for cases when there's a single verse
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // A constructor for cases when there are multiple verses
    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // A method that displays formatted reference based on a conditional check
    public string GetReference()
    {
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