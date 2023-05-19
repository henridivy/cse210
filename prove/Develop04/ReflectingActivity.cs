public class ReflectingActivity : Acitivy
{
    public List<string> _reflectionPrompts = new List<string>() { };
    private string GetPromptFromFile(string filename)
    {
        _reflectionPrompts.Clear();

        // read from the text file with prompts
        string[] lines = System.IO.File.ReadAllLines(filename);

        // add each line (prompt) from the text file to the list of prompts
        foreach (string line in lines)
        {
            _reflectionPrompts.Add(line);
        }

        // use Random to get a random index from the length of the prompts list
        var random = new Random();
        int index = random.Next(_reflectionPrompts.Count);
        // assign the randomPrompt variable to whatever was in the random index we got
        string randomPrompt = _reflectionPrompts[index];
        // remove the prompt from the list so it doesn't choose it again
        _reflectionPrompts.Remove(_reflectionPrompts[index]);

        return randomPrompt;
    }

    public void PresentPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Console.Write(" --- ");
        Console.Write(GetPromptFromFile("reflectionPrompts.txt"));
        Console.WriteLine(" --- ");
        Console.WriteLine();
        
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown(6);
    }

    public void AskQuestions()
    {
        Console.Clear();
        int secondsSoFar = 0;
        int duration = GetActivityDuration();

        while (secondsSoFar < duration)
        {
            Console.Write("> " + GetPromptFromFile("reflectionQuestions.txt") +  " ");

            DisplaySpinner(10);
            Console.WriteLine();

            secondsSoFar += 10;
        }

        Console.WriteLine();
    }
}
