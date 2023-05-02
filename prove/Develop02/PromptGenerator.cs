using System;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    
    public string ChooseRandomPrompt()
    {
        // read from the text file with prompts
        string filename = "prompts.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        // add each line (prompt) from the text file to the list of prompts
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }

        // use Random to get a random index from the length of the prompts list
        var random = new Random();
        int index = random.Next(_prompts.Count);
        // assign the randomPrompt variable to whatever was in the random index we got
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }
}
