using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // create a new instance of the class Journal
        // basically creates a new journal called myJournal
        Journal myJournal = new Journal();

        // create menu and user input variables
        int menuUserInput = 0;

        List<string> menu = new List<String>
        {
            "Please select one of the following choices:",
            "1. Write a new entry",
            "2. Display the journal",
            "3. Load the journal from a file",
            "4. Save the journal to a file",
            "5. Quit",
            "What would you like to do?"
        };

        // while user input is not 5, keep displaying the menu
        while (menuUserInput != 5)
        {
            // display the menu line by line
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
            
            // turn user's input to an integer and replace the old value
            menuUserInput = int.Parse(Console.ReadLine());

            if (menuUserInput == 1)
            {
                Console.WriteLine();
                // create a new instance of the class PromptGenerator
                PromptGenerator generator = new PromptGenerator();
                // use the ChooseRandomPrompt method to get a random prompt
                string randomPrompt = generator.ChooseRandomPrompt();
                // display the prompt in the terminal
                Console.WriteLine(randomPrompt);

                string userResponse = Console.ReadLine();


                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                // use the prompt to create a journal entry with the user's response and current date
                myJournal.CreateJournalEntry(randomPrompt, dateText, userResponse);
            }

            else if (menuUserInput == 2)
            {
                myJournal.DisplayJournalEntries();
            }

            else if (menuUserInput == 3)
            {
                myJournal.LoadFromCSV(myJournal);
                
                // using (StreamReader journalFile = new StreamReader(filename))
                // {
                //     string line;
                //     while ((line = journalFile.ReadLine()) != null)
                //     {
                        
                //     }
                // }

            }

            else if (menuUserInput == 4)
            {
                myJournal.SaveToCSV(myJournal);
            }

            Console.WriteLine();
        }
        // switch statement for user input
    }
}