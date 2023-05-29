using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        Console.WriteLine("Hello and welcome! I am your Language Assistant. \n");
        Console.WriteLine("I will assist you in learning a language of your choice. Study the given material and advance through the 5 levels, each one increasing in difficulty. \n");
        Console.WriteLine("Earn badges as you reach important milestones and unlock new levels.");
        Console.Write("(Press enter to continue) ");
        Console.ReadLine();
        Console.WriteLine();

        // create a list of strings for the menu
        List<string> menu = new List<String>
        {
            "Spanish",
            "French",
            "Portuguese",
            "Latin",
            "Filipino",
            "Quit"
        };

        int menuChoice = 0;
        int totalPoints = 0;

        while (menuChoice != 6)
        {
            Console.Clear();
            Console.WriteLine("---------- LANGUAGES ----------");

            // display the menu line by line
            int i = 1;
            foreach (string item in menu)
            {
                Console.WriteLine($"{i}. {item}");
                i++;
            }

            Console.Write("Input the number of your choice: ");
            menuChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Clear();

            string languageChoice = menu[menuChoice-1];
            Console.WriteLine($"You have chosen {languageChoice}.");

            Language newLanguage = new Language();
            
            if (languageChoice == "Spanish")
            {
                newLanguage = new Spanish(languageChoice);
            }
            else if (languageChoice == "French")
            {
                newLanguage = new French(languageChoice);
            }

            Console.WriteLine();
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();

            Console.WriteLine("-----Level 1: Vocabulary-----");
            Console.Write("Study each item in the vocabulary list, pressing enter to continue. After you've gone through all the words, and you feel confident enough, you may take the quiz. \n");
            Console.ReadLine();
            Console.WriteLine();

            newLanguage.DisplayVocabList();

            Console.WriteLine("You have studied all the words! Ready for the test? ");

            Console.Clear();

            Console.WriteLine("In this level, 5 points are earned for every correct answer; 3 points are lost for every wrong answer. \n\n Unlock Level 2 by reaching 50 points.");

            Console.Write("Begin test!");
            Console.ReadLine();

            // VocabQuestion.AskQuestions(totalPoints);

            
        }


    }
}