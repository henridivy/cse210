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
    public void CreateJournalEntry(string prompt, string date, string response)
    {
        Entry newEntry = new Entry();

        // DateTime theCurrentTime = DateTime.Now;
        // string dateText = theCurrentTime.ToShortDateString();

        newEntry._response = response;
        newEntry._prompt = prompt;
        newEntry._date = date;

        // add the new entry and its attributes to the list of entries
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

    // create a method that saves all entries so far to a file
    public void SaveFile(Journal journalName)
    {
        // give a name to this file
        Console.Write("What is the name of the file? ");
        string filename = Console.ReadLine();
        // assign a password to this journal
        Console.Write("What's the password? ");
        string password = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // for each entry in the entries list, write a line in the file with the entry information, separated by ||
            foreach (Entry entry in journalName._entries)
            {
                outputFile.WriteLine($"{entry._date}||{entry._prompt}||{entry._response}");
            }

            // write the password after writing all the entries
            outputFile.WriteLine();
            outputFile.WriteLine($"Password: {password}");
        }
    }

    // create a method that loads an existing file with journal entries, where you can continue to add entries
    public void LoadFile(Journal journalName)
    {
        Console.Write("What is the name of the file? ");
        string filename = Console.ReadLine();

        // ask the user for a password to access this journal
        Console.Write("What's the password? ");
        string password = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        // get the index of the last line, where the password would be stored
        int lastIndex = lines.Count() - 1;

        // if the password is correct...
        if (lines[lastIndex] == $"Password: {password}")
        {
            // clear the previous saved entries so files don't combine
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split("||");

                // check if the line has more than one part, this ensures it doesn't include the password or blank spaces
                if (parts.Count() > 1)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    
                    journalName.CreateJournalEntry(prompt, date, response);
                }
            }
        }
        else 
        {
            Console.WriteLine("Password is incorrect.");
        }
    }
}
