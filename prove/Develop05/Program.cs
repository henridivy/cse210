using System;

class Program
{
    static void Main(string[] args)
    {
        // initialize user's input to 0
        int menuUserInput = 0;

        // create a list of strings for the menu
        List<string> menu = new List<String>
        {
            "Menu Options:",
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit"
        };

        // initialize total points to 0
        int totalPoints = 0;

        // create a list of goals
        List<Goal> allGoals = new List<Goal>();

        while (menuUserInput != 6)
        {
            // Console.Clear();

            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();

            // display the menu line by line
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.Write("Select an option from the menu: ");
            menuUserInput = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (menuUserInput == 1)
            {
                Console.WriteLine("The type of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine();
                Console.Write("What type of goal would you like to create? " );

                int goalChoice = int.Parse(Console.ReadLine());

                if (goalChoice == 1)
                {
                    SimpleGoal newSimpleGoal = new SimpleGoal();
                    newSimpleGoal.CreateNewGoal();
                    Console.WriteLine();

                    allGoals.Add(newSimpleGoal);
                }

                else if (goalChoice == 2)
                {
                    EternalGoal newEternalGoal = new EternalGoal();
                    newEternalGoal.CreateNewGoal();
                    Console.WriteLine();

                    allGoals.Add(newEternalGoal);
                }

                else if (goalChoice == 3)
                {
                    ChecklistGoal newChecklistGoal = new ChecklistGoal();
                    newChecklistGoal.CreateNewGoal();
                    Console.WriteLine();

                    allGoals.Add(newChecklistGoal);
                }
            }

            else if (menuUserInput == 2)
            {
                int i = 1;
                Console.WriteLine("Your goals are: ");

                foreach (Goal goal in allGoals)
                {
                    Console.Write(i + ". ");
                    goal.DisplayGoal();
                    Console.WriteLine();
                    i++;
                }
            }
            
            else if (menuUserInput == 3)
            {
                Console.WriteLine("What is the name of the file? ");
                string filename = Console.ReadLine();
                
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine($"{totalPoints} points");
                    // for each entry in the entries list, write a line in the file with the entry information, separated by ||
                    foreach (Goal goal in allGoals)
                    {
                        goal.ListGoalInFile(outputFile);
                    }

                }    
            }

            else if (menuUserInput == 4)
            {
                Console.WriteLine("What file do you want to load? ");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);

                // clear the previous saved goals so files don't combine
                allGoals.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split("||");

                    // check if the line has more than one part, this ensures it doesn't include the first line with the points
                    if (parts.Count() > 1)
                    {
                        string goalType = parts[0];
                        string goalName = parts[1];
                        string goalDescription = parts[2];
                        string goalPoints = parts[3];
                        
                        // journalName.CreateJournalEntry(prompt, date, response);
                    }
                }
            }

            else if (menuUserInput == 5)
            {
                
            }
        }       
    }
}