public class ListingActivity : Acitivy
{
    private List<string> _listingPrompts = new List<string>() { };
    
    private string GetPromptFromFile(string filename)
    {
        _listingPrompts.Clear();

        // read from the text file with prompts
        string[] lines = System.IO.File.ReadAllLines(filename);

        // add each line (prompt) from the text file to the list of prompts
        foreach (string line in lines)
        {
            _listingPrompts.Add(line);
        }

        // use Random to get a random index from the length of the prompts list
        var random = new Random();
        int index = random.Next(_listingPrompts.Count);
        // assign the randomPrompt variable to whatever was in the random index we got
        string randomPrompt = _listingPrompts[index];
        // remove the prompt from the list so it doesn't choose it again
        _listingPrompts.Remove(_listingPrompts[index]);

        return randomPrompt;
    }

    public void PresentPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        Console.Write(" --- ");
        Console.Write(GetPromptFromFile("listingPrompts.txt"));
        Console.WriteLine(" --- ");
        Console.WriteLine();
        
        Console.Write("You may begin in: ");
        Countdown(9);
        Console.WriteLine();
    }

    public void AllowUserToList()
    {
        int duration = GetActivityDuration();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        
        DateTime currentTime = DateTime.Now;
        int numOfItems = 0;

        do 
        {
            currentTime = DateTime.Now;
            Console.Write("> ");
            Console.ReadLine();
            numOfItems++;
        } while (currentTime < futureTime);

        Console.WriteLine($"You listed {numOfItems} items!");
        Console.WriteLine();
    }
}