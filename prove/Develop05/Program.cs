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
            Console.WriteLine();
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

            // if the user chooses to create a new goal
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

            // if the user chooses to list all goals
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
            
            // if the user chooses to save goals to a file
            else if (menuUserInput == 3)
            {
                Console.WriteLine("What is the name of the file? ");
                string filename = Console.ReadLine();
                
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine($"{totalPoints}");
                    // for each entry in the entries list, write a line in the file with the entry information, separated by ||
                    foreach (Goal goal in allGoals)
                    {
                        goal.ListGoalInFile(outputFile);
                    }

                }    
            }

            // if the user chooses to load goals
            else if (menuUserInput == 4)
            {
                Console.WriteLine("What file do you want to load? ");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);

                // clear the previous saved goals so files don't combine
                allGoals.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(">>");

                    // check if the line has more than one part, this ensures it doesn't include the first line with the points
                    if (parts.Count() > 1)
                    {
                        string goalType = parts[0];
                        string goalName = parts[1];
                        string goalDescription = parts[2];
                        int goalPoints = int.Parse(parts[3]);

                        // this is for simple goals, which have the extra boolean
                        if (parts.Count() == 5)
                        {
                            bool isCompleted = bool.Parse(parts[4]);

                            SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, isCompleted);
                            allGoals.Add(newSimpleGoal);
                        }
                        
                        // this is for checklist goals, which have the extra bonus points, number of times to complete, and number of times already completed
                        else if (parts.Count() == 7)
                        {
                            int bonusPoints = int.Parse(parts[4]);
                            int numTotal = int.Parse(parts[5]);
                            int numCompleted = int.Parse(parts[6]);

                            ChecklistGoal newChecklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, bonusPoints, numTotal, numCompleted);
                            allGoals.Add(newChecklistGoal);
                        }

                        else
                        {
                            EternalGoal newEternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                            allGoals.Add(newEternalGoal);
                        }
                    }
                    else if (parts.Count() == 1)
                    {
                        totalPoints = int.Parse(parts[0]);
                    }
                }
            }

            // if the user chooses to record an event
            else if (menuUserInput == 5)
            {
                int i = 1;
                Console.WriteLine("Your goals are: ");

                foreach (Goal goal in allGoals)
                {
                    Console.Write(i + ". ");
                    Console.WriteLine(goal.GetGoalName());
                    i++;
                }

                Console.Write("Which goal did you accomplish? ");
                int accomplishedGoalNum = int.Parse(Console.ReadLine());
                
                Goal accomplishedGoal = allGoals[accomplishedGoalNum - 1];

                // add the appropriate goal points to the total points
                totalPoints += accomplishedGoal.GetGoalPoints();

                // record the goal as completed accordingly
                accomplishedGoal.RecordGoal();
                Console.WriteLine($"You now have {totalPoints} points.");
                Console.WriteLine();
            }
        }       
    }
}