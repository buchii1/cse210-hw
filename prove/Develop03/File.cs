using System.Collections.Generic;
using System.IO;

public class File
{
    private Dictionary<string, string> scriptures_ = new Dictionary<string, string>();

    public void ReadFile() {
        string file = "scriptures.txt";

        string[] entries = System.IO.File.ReadAllLines(file);

        foreach (string entry in entries)
        {
            string[] lines = entry.Split(" - ");
            string reference = lines[0];
            string text = lines[1].Trim('"');

            scriptures_.Add(reference, text);
        }
    }

    public KeyValuePair<string, string> GetRandomScripture()
    {
        int scriptureLength = scriptures_.Count;
        
        if (scriptureLength == 0)
        {
            throw new InvalidOperationException("There are no scriptures in the dictionary.");
        }
        else
        {
            Random random = new Random();
            int randIndex = random.Next(scriptureLength);

            KeyValuePair<string, string> randomScripture = scriptures_.ElementAt(randIndex);
            return randomScripture;
        }
    }

    public List<string> OutputScripture()
    {
        int counter = 0;
        List<string> display = new List<string>();

        foreach (KeyValuePair<string, string> entry in scriptures_)
        {
            string word = $"{counter + 1 }. {entry.Key}";
            display.Add(word);
            counter ++;
        }

        return display;
    }

    public KeyValuePair<string, string> DisplaySelectedScripture(int selection)
    {
        KeyValuePair<string, string> selectedScripture = scriptures_.ElementAt(selection - 1);
        return selectedScripture;
    }
}