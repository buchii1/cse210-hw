// A code template for the category of things known as Word.
// The responsibility of a Word is to show, and hide word in the scripture
public class Word
{
    private string _word;
    private bool _isHidden;

    // A constructor that accepts one argument and set the value word
    // to be hidden by default
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    // A method that returns the _isHidden attribute of the word
    public bool IsHidden()
    {
        return _isHidden;
    }

    // A function that hides a word
    public void HideWord()
    {
        _isHidden = true;
    }

    // A getter that replaces hidden words with "_" and displays the word
    public string GetWord()
    {
        string hidden = "";

        // Condition to run if the word is hidden
        if (_isHidden)
        {
            // Loop through the length of the hidden word
            for (int i = 0; i < _word.Length; i++)
            {
                // Replace each index with an _
                hidden += "_";
            }
            return hidden;
        }
        else
        {
            return _word;
        }
    }
}