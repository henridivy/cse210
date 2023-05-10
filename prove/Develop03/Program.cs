using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create variables for the reference and the text of the scripture
        Reference scriptureReference = new Reference();
        string scriptureText = "";
        
        Reference moses = new Reference("Moses", "1", "39");
        Reference nephi = new Reference("2 Nephi", "32", "3");
        Reference jacob = new Reference("Jacob", "2", "18", "19");

        string mosesText = "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.";
        string nephiText = "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.";
        string jacobText = "But before ye seek for riches, seek ye for the kingdom of God. And after ye have obtained a hope in Christ ye shall obtain riches, if ye seek them; and ye will seek them for the intent to do good—to clothe the naked, and to feed the hungry, and to liberate the captive, and administer relief to the sick and the afflicted.";

        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Console.WriteLine("Please input the number of the scripture you would like to master.");

        Console.WriteLine($"1 > {moses.GetReference()}");
        Console.WriteLine($"2 > {nephi.GetReference()}");
        Console.WriteLine($"3 > {jacob.GetReference()}");

        Console.WriteLine();
        Console.Write("Scripture: ");
        int userScripture = int.Parse(Console.ReadLine());

        // assign the reference and the text of the scripture
        if (userScripture == 1)
        {
            scriptureReference = moses; 
            scriptureText = mosesText;
        }
        else if (userScripture == 2)
        {
            scriptureReference = nephi; 
            scriptureText = nephiText;
        }
        else
        {
            scriptureReference = jacob; 
            scriptureText = jacobText;
        }


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