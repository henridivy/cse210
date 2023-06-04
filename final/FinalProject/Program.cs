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

        // initialize these values
        int menuChoice = 0;
        // int totalPoints = 0;

        // while the user does not choose to quit...
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

            // get the user's choice
            Console.Write("Input the number of your choice: ");
            menuChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();

            if (menuChoice != 6)
            {
                // display the user's choice
                string languageChoice = menu[menuChoice-1];
                Console.WriteLine($"You have chosen {languageChoice}.");

                // create a new instance of the Language class
                Language newLanguage = new Language();
                
                // change that instance to whichever specific language the user chose
                if (languageChoice == "Spanish")
                {
                    newLanguage = new Spanish(languageChoice, 1);
                }
                else if (languageChoice == "French")
                {
                    newLanguage = new French(languageChoice, 2);
                }
                else if (languageChoice == "Portuguese")
                {
                    newLanguage = new Portuguese(languageChoice, 3);
                }
                else if (languageChoice == "Latin")
                {
                    newLanguage = new French(languageChoice, 4);
                }
                else if (languageChoice == "Filipino")
                {
                    newLanguage = new Portuguese(languageChoice, 5);
                }


                // ------------- LEVEL 1 ---------------

                // display the user's total points
                Console.WriteLine();
                Console.WriteLine($"You have {newLanguage.GetTotalPoints()} points.");
                Console.WriteLine();

                // introduce level 1
                Console.WriteLine("-----LEVEL 1: Vocabulary-----");
                Console.Write("Study each item in the vocabulary list, pressing enter to continue. After you've gone through all the words, and you feel confident enough, you may take the quiz.");
                Console.ReadLine();
                Console.WriteLine();

                // call the method to show the vocabulary list
                newLanguage.DisplayList("vocabulary.txt");

                Console.WriteLine("You have studied all the words! Time for the test! ");

                Console.Clear();

                // give test instructions
                Console.WriteLine("In this level, 5 points are earned for every correct answer; 3 points are lost for every wrong answer. \nUnlock Level 2 by reaching 50 points.");

                Console.Write("\nBegin test!");
                Console.ReadLine();
                newLanguage.Countdown(3);

                // create an instance of the vocab question
                VocabQuestion newVocabQuestion = new VocabQuestion();

                newVocabQuestion.SetCorrectPoints(5);
                newVocabQuestion.SetWrongPoints(-3);

                // until the user's points reaches 50, ask a vocab question
                while (newLanguage.GetTotalPoints() < 50)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have {newLanguage.GetTotalPoints()} points.");
                    Console.WriteLine();

                    int earnedPoints = newVocabQuestion.AskQuestion(newLanguage.GetTotalPoints(), newLanguage.GetLanguageIndex(), newLanguage.GetLanguageName());

                    newLanguage.AddToTotalPoints(earnedPoints);
                }
                
                // when the user gets to 50 points, complete the level and get a badge
                if (newLanguage.GetTotalPoints() >= 50)
                {
                    Console.Clear();
                    Console.Write("LEVEL 1 COMPLETED!");
                    Console.ReadLine();
                    Console.WriteLine("<Newbie Badge> ACQUIRED!");

                    // create new instance of a NewbieBadge, then display it
                    NewbieBadge badge1 = new NewbieBadge();
                    badge1.CreateBadge();
                    badge1.DisplayBadge();

                    // add the badge to the list of acquired badges
                    newLanguage.AddBadgeToList(badge1);

                    Console.WriteLine("LEVEL 2 UNLOCKED! ");
                    Console.WriteLine("(Press enter to continue) ");
                    Console.ReadLine();
                }

                // ------------- LEVEL 2 ---------------
                // ------------- LEVEL 2 ---------------
                // ------------- LEVEL 2 ---------------
                // ------------- LEVEL 2 ---------------

                // display the user's total points
                Console.Clear();
                Console.WriteLine($"You have {newLanguage.GetTotalPoints()} points.");
                Console.WriteLine();

                // introduce level 1
                Console.WriteLine("-----LEVEL 2: Numbers and Time-----");
                Console.Write("Study the numbers and time terms in the list, pressing enter to continue. After you've gone through all the words, and you feel confident enough, you may take the quiz.");
                Console.ReadLine();
                Console.WriteLine();

                // call the method to show the vocabulary list
                newLanguage.DisplayList("numTime.txt");

                Console.WriteLine("You have studied all the terms! Time for the test! ");

                Console.Clear();

                // give test instructions
                Console.WriteLine("In this level, 10 points are earned for every correct answer; 7 points are lost for every wrong answer. \nUnlock Level 3 by reaching 150 points.");

                Console.Write("\nBegin test!");
                Console.ReadLine();
                newLanguage.Countdown(3);

                // create an instance of the vocab question
                NumTimeQuestion newNumTimeQuestion = new NumTimeQuestion();

                newNumTimeQuestion.SetCorrectPoints(10);
                newNumTimeQuestion.SetWrongPoints(-7);

                // until the user's points reaches 150, ask a numTime question
                while (newLanguage.GetTotalPoints() < 150)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have {newLanguage.GetTotalPoints()} points.");
                    Console.WriteLine();

                    int earnedPoints = newNumTimeQuestion.AskQuestion(newLanguage.GetTotalPoints(), newLanguage.GetLanguageIndex(), newLanguage.GetLanguageName());

                    newLanguage.AddToTotalPoints(earnedPoints);
                }
                
                // when the user gets to 150 points, complete the level and get a badge
                if (newLanguage.GetTotalPoints() >= 150)
                {
                    Console.Clear();
                    Console.Write("LEVEL 2 COMPLETED!");
                    Console.ReadLine();
                    Console.WriteLine("<Mathematician Badge> ACQUIRED!");

                    // create new instance of a NewbieBadge, then display it
                    MathematicianBadge badge2 = new MathematicianBadge();
                    badge2.CreateBadge();
                    badge2.DisplayBadge();

                    // add the badge to the list of acquired badges
                    newLanguage.AddBadgeToList(badge2);
                    
                    Console.WriteLine("LEVEL 3 UNLOCKED! ");
                    Console.WriteLine("(Press enter to continue) ");
                    Console.ReadLine();
                }

                // ------------- LEVEL 3 ---------------
                // ------------- LEVEL 3 ---------------
                // ------------- LEVEL 3 ---------------
                // ------------- LEVEL 3 ---------------

                // display the user's total points
                Console.Clear();
                Console.WriteLine($"You have {newLanguage.GetTotalPoints()} points.");
                Console.WriteLine();

                // introduce level 1
                Console.WriteLine("-----LEVEL 3: Dates-----");
                Console.Write("Study the dates terms in the list, pressing enter to continue. After you've gone through all the words, and you feel confident enough, you may take the quiz.");
                Console.ReadLine();
                Console.WriteLine();

                // call the method to show the vocabulary list
                newLanguage.DisplayList("dates.txt");

                Console.WriteLine("You have studied all the terms! Time for the test! ");

                Console.Clear();

                // give test instructions
                Console.WriteLine("In this level, 15 points are earned for every correct answer; 10 points are lost for every wrong answer. \nUnlock Level 4 by reaching 300 points.");

                Console.Write("\nBegin test!");
                Console.ReadLine();
                newLanguage.Countdown(3);

                // create an instance of the vocab question
                DatesQuestion newDatesQuestion = new DatesQuestion();

                newDatesQuestion.SetCorrectPoints(15);
                newDatesQuestion.SetWrongPoints(-10);

                // until the user's points reaches 300, ask a dates question
                while (newLanguage.GetTotalPoints() < 300)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have {newLanguage.GetTotalPoints()} points.");
                    Console.WriteLine();

                    int earnedPoints = newDatesQuestion.AskQuestion(newLanguage.GetTotalPoints(), newLanguage.GetLanguageIndex(), newLanguage.GetLanguageName());

                    newLanguage.AddToTotalPoints(earnedPoints);
                }
                
                // when the user gets to 300 points, complete the level and get a badge
                if (newLanguage.GetTotalPoints() >= 300)
                {
                    Console.Clear();
                    Console.Write("LEVEL 3 COMPLETED!");
                    Console.ReadLine();
                    Console.WriteLine("<Time Warper Badge> ACQUIRED!");

                    // create new instance of a NewbieBadge, then display it
                    TimeWarperBadge badge3 = new TimeWarperBadge();
                    badge3.CreateBadge();
                    badge3.DisplayBadge();

                    // add the badge to the list of acquired badges
                    newLanguage.AddBadgeToList(badge3);
                    
                    Console.WriteLine("LEVEL 4 UNLOCKED! ");
                    Console.WriteLine("(Press enter to continue) ");
                    Console.ReadLine();
                }


                // ------------- LEVEL 4 ---------------
                // ------------- LEVEL 4 ---------------
                // ------------- LEVEL 4 ---------------
                // ------------- LEVEL 4 ---------------

                // display the user's total points
                Console.Clear();
                Console.WriteLine($"You have {newLanguage.GetTotalPoints()} points.");
                Console.WriteLine();

                // introduce level 1
                Console.WriteLine("-----LEVEL 4: Short Phrases-----");
                Console.Write("Study the words and phrases in the list, pressing enter to continue. After you've gone through all the phrases, and you feel confident enough, you may take the quiz.");
                Console.ReadLine();
                Console.WriteLine();

                // call the method to show the vocabulary list
                newLanguage.DisplayList("shortPhrases.txt");

                Console.WriteLine("You have studied all the terms! Time for the test! ");

                Console.Clear();

                // give test instructions
                Console.WriteLine("In this level, 20 points are earned for every correct answer; 13 points are lost for every wrong answer. \nUnlock Level 5 by reaching 500 points.");

                Console.Write("\nBegin test!");
                Console.ReadLine();
                newLanguage.Countdown(3);

                // create an instance of the vocab question
                ShortPhrasesQuestion newShortPhrasesQuestion = new ShortPhrasesQuestion();

                newShortPhrasesQuestion.SetCorrectPoints(20);
                newShortPhrasesQuestion.SetWrongPoints(-13);

                // until the user's points reaches 300, ask a short phrases question
                while (newLanguage.GetTotalPoints() < 500)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have {newLanguage.GetTotalPoints()} points.");
                    Console.WriteLine();

                    int earnedPoints = newShortPhrasesQuestion.AskQuestion(newLanguage.GetTotalPoints(), newLanguage.GetLanguageIndex(), newLanguage.GetLanguageName());

                    newLanguage.AddToTotalPoints(earnedPoints);
                }
                
                // when the user gets to 500 points, complete the level and get a badge
                if (newLanguage.GetTotalPoints() >= 500)
                {
                    Console.Clear();
                    Console.Write("LEVEL 4 COMPLETED!");
                    Console.ReadLine();
                    Console.WriteLine("<Community Helper Badge> ACQUIRED!");

                    // create new instance of a CommunityHelperBadge, then display it
                    CommunityHelperBadge badge4 = new CommunityHelperBadge();
                    badge4.CreateBadge();
                    badge4.DisplayBadge();

                    // add the badge to the list of acquired badges
                    newLanguage.AddBadgeToList(badge4);
                    
                    Console.WriteLine("LEVEL 5 UNLOCKED! ");
                    Console.WriteLine("(Press enter to continue) ");
                    Console.ReadLine();
                }


                // ------------- LEVEL 5 ---------------
                // ------------- LEVEL 5 ---------------
                // ------------- LEVEL 5 ---------------
                // ------------- LEVEL 5 ---------------

                // display the user's total points
                Console.Clear();
                Console.WriteLine($"You have {newLanguage.GetTotalPoints()} points.");
                Console.WriteLine();

                // introduce level 5
                Console.WriteLine("-----LEVEL 5: Self-Introduction-----");
                Console.Write("Study the phrases in the list, pressing enter to continue. After you've gone through all the phrases, and you feel confident enough, you may take the quiz.");
                Console.ReadLine();
                Console.WriteLine();

                // call the method to show the vocabulary list
                newLanguage.DisplayList("selfIntro.txt");

                Console.WriteLine("You have studied all the terms! Time for the test! ");

                Console.Clear();

                // give test instructions
                Console.WriteLine("In this level, 25 points are earned for every correct answer; 18 points are lost for every wrong answer. \nFinish by reaching 750 points.");

                Console.Write("\nBegin test!");
                Console.ReadLine();
                newLanguage.Countdown(3);

                // create an instance of the vocab question
                SelfIntroQuestion newSelfIntroQuestion = new SelfIntroQuestion();

                newSelfIntroQuestion.SetCorrectPoints(25);
                newSelfIntroQuestion.SetWrongPoints(-18);

                // until the user's points reaches 750, ask a self-intro question
                while (newLanguage.GetTotalPoints() < 750)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have {newLanguage.GetTotalPoints()} points.");
                    Console.WriteLine();

                    int earnedPoints = newSelfIntroQuestion.AskQuestion(newLanguage.GetTotalPoints(), newLanguage.GetLanguageIndex(), newLanguage.GetLanguageName());

                    newLanguage.AddToTotalPoints(earnedPoints);
                }
                
                // when the user gets to 500 points, complete the level and get a badge
                if (newLanguage.GetTotalPoints() >= 750)
                {
                    Console.Clear();
                    Console.Write("LEVEL 5 COMPLETED!");
                    Console.ReadLine();
                    Console.WriteLine("<Mastermind Badge> ACQUIRED!");

                    // create new instance of a MastermindBadge, then display it
                    MastermindBadge badge5 = new MastermindBadge();
                    badge5.CreateBadge();
                    badge5.DisplayBadge();

                    // add the badge to the list of acquired badges
                    newLanguage.AddBadgeToList(badge5);
                    
                    Console.WriteLine("ALL LEVELS COMPLETED! Proceed to final exam. ");
                    Console.WriteLine("(Press enter to continue) ");
                    Console.ReadLine();
                }

                // ---------FINAL EXAM----------
                // ---------FINAL EXAM----------
                // ---------FINAL EXAM----------
                // ---------FINAL EXAM----------


                // introduce final exam
                Console.Clear();
                Console.WriteLine("-----FINAL EXAM-----");
                Console.Write($"Now that you have learned and mastered all the study terms of {newLanguage.GetLanguageName()}, it is time to have one final test. Answer the questions correctly until you reach 1,000 points. Then you will be awarded your final badge.");
                Console.ReadLine();
                Console.WriteLine();

                // give test instructions
                Console.WriteLine("Every question still has its corresponding correct and wrong points.");
                Console.WriteLine("Vocabulary (+5 / -3)");
                Console.WriteLine("Numbers and Time (+10 / -7)");
                Console.WriteLine("Dates (+15 / -10)");
                Console.WriteLine("Short Phrases (+20 / -13)");
                Console.WriteLine("Self-Introduction (+25 / -18)");
                Console.ReadLine();

                Console.WriteLine();
                Console.Write("\nBegin test!");
                Console.ReadLine();
                newLanguage.Countdown(5);

                Console.Clear();

                // give the final exam
                while (newLanguage.GetTotalPoints() < 1000)
                {
                    Console.WriteLine($"You have {newLanguage.GetTotalPoints()} points.");
                    Console.WriteLine();
                    newLanguage.AskFinalExamQuestion();
                }

                Console.Clear();

                Console.WriteLine($"You have {newLanguage.GetTotalPoints()} points.");
                Console.WriteLine("\nYou passed the final exam! HOORAY!");
                Console.WriteLine($"You have now mastered the basics of {newLanguage.GetLanguageName()} and acquired the <World Traveler Badge>!");

                // create new instance of a WorldTravelerBadge, then display it
                WorldTravelerBadge finalBadge = new WorldTravelerBadge();
                finalBadge.CreateBadge();
                finalBadge.DisplayBadge();

                // add the badge to the list of acquired badges
                newLanguage.AddBadgeToList(finalBadge);

                Console.WriteLine("Press enter to return to the menu and choose a new language to begin learning!");
            }            
        }
    }
}