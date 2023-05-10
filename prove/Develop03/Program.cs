using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create the reference and the text for the scripture
        Reference scriptureReference = new Reference("2 Nephi", "32", "3");
        string scriptureText = "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.";

        // create a new instance of Scripture class using the above reference and scripture text
        Scripture scripture = new Scripture(scriptureReference, scriptureText);

        // create a variable for the user's input
        string userInput = "";

        // while the user doesn't type quit and the scripture isn't completely hidden...
        while (userInput != "quit" && scripture.IsCompletelyHidden() == false)
        {
            // clear the console
            Console.Clear();
            // display the scripture, with its hidden words if there are any
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            // get user's input
            userInput = Console.ReadLine();
            // hide random words
            scripture.HideRandomWords();
        }
        
        // display message
        Console.WriteLine($"Congrats, you have memorized {scriptureReference.GetReference()}!");
    }
}