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
    public void CreateJournalEntry(string prompt)
    {
        Entry newEntry = new Entry();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        newEntry._response = Console.ReadLine();
        newEntry._prompt = prompt;
        newEntry._date = dateText;
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

    public void SaveToCSV(Journal journalName)
    {
        Console.WriteLine("What is the name of the file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in journalName._entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
            }

        }
    }
}