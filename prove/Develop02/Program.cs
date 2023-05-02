using System;

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
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
            menuUserInput = int.Parse(Console.ReadLine());

            if (menuUserInput == 1)
            {
                PromptGenerator generator = new PromptGenerator();
                generator.ChooseRandomPrompt();
            }
        }
        // switch statement for user input
    }
}