using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("2 Nephi", "32", "3");
        string scriptureText = "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.";
//         
        Scripture scripture = new Scripture(scriptureReference, scriptureText);

        string userInput = "";

        while (userInput != "quit" && scripture.IsCompletelyHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.ReadLine();
            scripture.HideRandomWords();
        }
        
        Console.WriteLine();
        Console.WriteLine($"Congrats, you have memorized {scriptureReference}!");
    }
}