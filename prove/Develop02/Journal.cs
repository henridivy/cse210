// create a Journal class
public class Journal
{
    // inside the class...
    // create a list of type Entry that will hold all the entries
    public List<Entry> _entries;

    // create a new instance of the list by initializing the entry to a new value
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // create a method that creates a journal entry
    public void CreateJournalEntry()
    {
        // give the user a random prompt
        

        Entry newEntry = new Entry();
        newEntry._response = Console.ReadLine();
        _entries.Add(newEntry);
    }

    // create a method that displays ALL journal entries
    public void DisplayJournalEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
}