using System.Collections.Generic;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();

    public void DisplayJournal()
    {
        foreach (Entry entry in _journal)
        {
            entry.DisplayEntry();
        }
    }
}