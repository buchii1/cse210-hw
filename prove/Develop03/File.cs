using System.Collections.Generic;
using System.IO;

// A code template for the category of things known as Files.
// The responsibility of a Reference is to read scriptures from
//      a file and appends them to a Dictionary
public class File
{
    private Dictionary<string, string> scriptures_ = new Dictionary<string, string>();

    // A method that reads data from a file and 
    //  populates the data in a dictionary
    public void ReadFile() {
        // File to be read
        string file = "scriptures.txt";

        // A call to the FileReader
        string[] entries = System.IO.File.ReadAllLines(file);

        // Loop through the entries list
        foreach (string entry in entries)
        {
            // Splits the words, remove trailing ""
            string[] lines = entry.Split(" - ");
            string reference = lines[0];
            string text = lines[1].Trim('"');

            // Adds the data to the dictionary
            scriptures_.Add(reference, text);
        }
    }

    // A method of type Dictionary that returns a random scripture
    //  from the _scriptures dictionary
    public KeyValuePair<string, string> GetRandomScripture()
    {
        int scriptureLength = scriptures_.Count;
        
        // Throw an error if the dictionary is empty
        if (scriptureLength == 0)
        {
            throw new InvalidOperationException("There are no scriptures in the dictionary.");
        }
        else
        {
            // Creates an instance of Random
            Random random = new Random();
            int randIndex = random.Next(scriptureLength);

            // Find the key value pair of the randIndex generated
            KeyValuePair<string, string> randomScripture = scriptures_.ElementAt(randIndex);
            return randomScripture;
        }
    }

    // A method of type List that returns the keys of the scripture
    //  dictionary as a list
    public List<string> OutputScripture()
    {
        int counter = 0;

        // A list to stores the keys of the dictionary
        List<string> display = new List<string>();

        // Loops through the dictionary and appends the keys and 
        //  it's index(es) to a list
        foreach (KeyValuePair<string, string> entry in scriptures_)
        {
            string word = $"{counter + 1 }. {entry.Key}";
            display.Add(word);
            counter ++;
        }

        return display;
    }

    // A getter method that accepts an integer index and returns the scripture
    //  corresponding to the index
    public KeyValuePair<string, string> DisplaySelectedScripture(int selection)
    {
        KeyValuePair<string, string> selectedScripture = scriptures_.ElementAt(selection - 1);
        return selectedScripture;
    }
}