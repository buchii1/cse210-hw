using System.Collections.Generic;

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

    public void HideWords() {
        int totText = _texts.Count;
        Random randNum = new Random();
        int counter = 0;

        foreach(Word word in _texts)
        {
            if (!word.IsHidden())
            {
                counter ++;
            }
        }

        if (counter >= 3)
        {
            for (int i = 0; i < 3; i++)
            {
                int index = randNum.Next(totText);
                Word word = _texts[index];

                while (word.IsHidden())
                {
                    index = randNum.Next(totText); 
                    word = _texts[index];
                }

                word.HideWord();
            }    
        }
        else
        {
            foreach (Word word in _texts)
            {
                if (!word.IsHidden())
                {
                    word.HideWord();
                }
            }
        }
    }

    public string GetRenderedText()
    {
        List<string> words = new List<string>();

        foreach (Word word in _texts)
        {
            string value = word.GetWord();

            if (word.IsHidden())
            {
                string hidden = "";
                
                for (int i = 0; i < value.Length; i++)
                {
                   hidden += "_";
                }
                words.Add(hidden);
            }
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