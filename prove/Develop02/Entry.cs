public class Entry
{
    // create attributes of the class Entry, so that every instance of the class Entry will have a date, prompt, and response
    public string _prompt = "";
    public string _response = "";
    public string _date = "";

    // public string GetEntry()
    // {

    // }

    public void DisplayEntry()
    {        
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }
}