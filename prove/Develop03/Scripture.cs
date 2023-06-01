using System.Collections.Generic;

// A code template for the category of things known as Scripture.
// The responsibility of a Scripture is to  randomly hide, show and display 
//  the text and reference to a scripture
public class Scripture
{
    private string _reference;
    private List<Word> _texts = new List<Word>();

    public Scripture(string reference, string text)
    {
        _reference = reference;
        
        // Split the text into a list
        string[] words = text.Split(" ");

        // Loop through the words list
        foreach(string word in words)
        {
            // Create a new word object for each word
            Word newWord = new Word(word);

            // Add the new word object to the list
            _texts.Add(newWord);
        }
    }

    // A method that checks if all the words in a dictionary 
    //  are completely hidden
    public  bool IsCompletelyHidden()
    {
        bool completelyHidden = true;

        foreach (Word word in _texts)
        {
            if (!word.IsHidden())
            {
                completelyHidden = false;
            }
        }

        return completelyHidden;
    }

    // A method that randomly hides three words in the _texts list
    public void HideWords() {
        // A variable to hold the value of the total
        //  items in the list
        int totText = _texts.Count;

        // Create an instance of Random
        Random randNum = new Random();

        // A variable to keep count of the number of unhidden words
        int counter = 0;

        // Loop through the _texts list and keep count
        //  of the words that are not hidden
        foreach(Word word in _texts)
        {
            if (!word.IsHidden())
            {
                counter ++;
            }
        }

        // Check if the number of hidden words are greater
        //  or equal to 3
        if (counter >= 3)
        {
            int index = -1; // Keeps track of the random _texts index
            Word word = null; // Initialize the word class to null

            // A loop that runs three times and automatically hides
            //  three random words
            for (int i = 0; i < 3; i++)
            {

                // Keep looping till it finds a word is not
                //  already hidden
                do
                {
                   // Choose a random index and find the value
                    index = randNum.Next(totText);
                    word = _texts[index]; 

                } while (word.IsHidden());

                // Hide the word
                word.HideWord();
            }    
        }

        // Condition to run if the number of hidden words
        //  are less than three
        else
        {   
            // Loop through the list and hide the remaining words
            foreach (Word word in _texts)
            {
                if (!word.IsHidden())
                {
                    word.HideWord();
                }
            }
        }
    }

    // A method that clears the console
    private void ClearConsole()
    {
        Console.Clear();
    }

    // A getter method that loops through the _text list, hide
    //  replaces the indexes of the hidden words and return then
    public string GetRenderedText()
    {   
        // Clear the Console
        ClearConsole();

        // A list to store the words in the _text list
        List<string> words = new List<string>();

        // Loop through the _texts list
        foreach (Word word in _texts)
        {
            // Get the value of each word
            string value = word.GetWord();

            // Condition to run if the word is hidden
            if (word.IsHidden())
            {
                string hidden = "";
                
                // Loop through the length of the hidden word
                for (int i = 0; i < value.Length; i++)
                {
                    // Replace each index with an _
                    hidden += "_";
                }
                // Add the hidden word to the dictionary
                words.Add(hidden);
            }

            // Add the word to the dictionary if it is not hidden 
            else {
                words.Add(value);
            }
        }

        // Covert list of texts to a single string
        string scriptureText = string.Join(" ", words);
        
        // Capitalize the first letter in the string
        scriptureText = char.ToUpper(scriptureText[0]) + scriptureText.Substring(1);
        string scripture = $"{_reference} {scriptureText}";

        return scripture;
    }
}