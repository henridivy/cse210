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

        // create a list to keep completed goals
        List<Goal> completedGoals = new List<Goal>();

        List<string> hoorayMessage = new List<string>();
        // hoorayMessage.Add("_______________________________________________________________");
        // hoorayMessage.Add("__________________$$$_________$$$_________$$$_________$$$______");
        // hoorayMessage.Add("_______________$$$$$$______$$$___$$$___$$$___$$$___$$$___$$$___");
        // hoorayMessage.Add("______$$$_________$$$______$$$___$$$___$$$___$$$___$$$___$$$___");
        // hoorayMessage.Add("___$$$$$$$$$______$$$______$$$___$$$___$$$___$$$___$$$___$$$___");
        // hoorayMessage.Add("______$$$_________$$$______$$$___$$$___$$$___$$$___$$$___$$$___");
        // hoorayMessage.Add("_______________$$$$$$$$$______$$$_________$$$_________$$$______");
        // hoorayMessage.Add("_______________________________________________________________");
        hoorayMessage.Add("                                                               ");
        hoorayMessage.Add("                  $$$         $$$         $$$         $$$      ");
        hoorayMessage.Add("               $$$$$$      $$$   $$$   $$$   $$$   $$$   $$$   ");
        hoorayMessage.Add("      $$$         $$$      $$$   $$$   $$$   $$$   $$$   $$$   ");
        hoorayMessage.Add("   $$$$$$$$$      $$$      $$$   $$$   $$$   $$$   $$$   $$$   ");
        hoorayMessage.Add("      $$$         $$$      $$$   $$$   $$$   $$$   $$$   $$$   ");
        hoorayMessage.Add("               $$$$$$$$$      $$$         $$$         $$$      ");
        hoorayMessage.Add("                                                               ");
        
       
        
        
        
        
        
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

                Console.WriteLine();

                int y = 1;
                Console.WriteLine("Completed goals: ");

                foreach (Goal completedGoal in completedGoals)
                {
                    Console.Write(y + ". ");
                    completedGoal.DisplayGoal();
                    Console.WriteLine();
                    y++;
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

                    foreach (Goal completedGoal in completedGoals)
                    {
                        completedGoal.ListGoalInFile(outputFile);
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
                completedGoals.Clear();

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
                        if (goalType == "SimpleGoal")
                        {
                            bool isCompleted = bool.Parse(parts[4]);

                            SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, isCompleted);
                            
                            if (newSimpleGoal.GetIsCompleted() == true)
                            {
                                completedGoals.Add(newSimpleGoal);
                            }
                            else 
                            {
                                allGoals.Add(newSimpleGoal);
                            }
                        }

                        // this is for checklist goals, which have the extra bonus points, number of times to complete, and number of times already completed
                        else if (goalType == "ChecklistGoal")
                        {
                            int bonusPoints = int.Parse(parts[4]);
                            int numTotal = int.Parse(parts[5]);
                            int numCompleted = int.Parse(parts[6]);

                            ChecklistGoal newChecklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, bonusPoints, numTotal, numCompleted);
                            if (newChecklistGoal.GetIsCompleted() == true)
                            {
                                completedGoals.Add(newChecklistGoal);
                            }
                            else 
                            {
                                allGoals.Add(newChecklistGoal);
                            }
                        }

                        else
                        {
                            int howManyTimes = int.Parse(parts[4]);
                            EternalGoal newEternalGoal = new EternalGoal(goalName, goalDescription, goalPoints, howManyTimes);
                            if (newEternalGoal.GetIsCompleted() == true)
                            {
                                completedGoals.Add(newEternalGoal);
                            }
                            else 
                            {
                                allGoals.Add(newEternalGoal);
                            }
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
                accomplishedGoal.MoveCompletedGoal(allGoals, completedGoals);
                Console.WriteLine($"You now have {totalPoints} points.");
                Console.WriteLine();
            }

            // check whether all simple and checklist goals have been completed
            

            if (allGoals.Count() > 0)
            {
                int controlNum = 0;
                
                foreach (Goal goal in allGoals)
                {
                    if (goal.GetType() == typeof(EternalGoal))
                    {
                        controlNum += 0;
                    }
                    else
                    {
                        controlNum ++;
                    }
                }

                if (controlNum == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hooray! All current goals have been completed! +1000 points!");
                    totalPoints += 1000;

                    foreach (string image in hoorayMessage)
                    {
                        Console.WriteLine(image);
                        // Thread.Sleep(200);
                        // Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                              \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    }
                }
            }
        }       
    }
}