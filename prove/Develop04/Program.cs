using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to the Mindfulness Program!");
        Console.WriteLine();

        // create an instance of the Breathing Activity and set its name and description
        BreathingActivity breathingAct = new BreathingActivity();
        breathingAct.SetActivityName("Breathing Activity");
        breathingAct.SetActivityDescription("This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");

        // create an instance of the Breathing Activity and set its name and description
        ReflectingActivity reflectingAct = new ReflectingActivity();
        reflectingAct.SetActivityName("Reflecting Activity");
        reflectingAct.SetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        // create an instance of the Breathing Activity and set its name and description
        ListingActivity listingAct = new ListingActivity();
        listingAct.SetActivityName("Listing Activity");
        listingAct.SetActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int menuUserInput = 0;

        List<string> menu = new List<String>
        {
            "Menu Options:",
            "1. Start breathing activity",
            "2. Start reflecting activity",
            "3. Start listing activity",
            "4. Quit",
        };

        // while user input is not 4, keep displaying the menu
        while (menuUserInput != 4)
        {
            Console.Clear();
            // display the menu line by line
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.Write("Select an option from the menu: ");

            menuUserInput = int.Parse(Console.ReadLine());

            if (menuUserInput == 1)
            {
                breathingAct.BeginActivity();
                breathingAct.GetReady();
                breathingAct.StartBreathingSequence();
                breathingAct.EndActivity();
            }

            else if (menuUserInput == 2)
            {
                reflectingAct.BeginActivity();
                reflectingAct.GetReady();
                reflectingAct.PresentPrompt();
                reflectingAct.AskQuestions();
                reflectingAct.EndActivity();
            }

            else if (menuUserInput == 3)
            {
                listingAct.BeginActivity();
            }
        }

        
    }
}