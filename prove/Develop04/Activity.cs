public class Acitivy
{
    private string _activityName = "";
    private string _activityDescription = "";
    private int _activityDuration = 0;

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public void GetReady()
    {
        Console.Clear();
        Console.Write("Get ready");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1200);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
        
    public void BeginActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? (You should enter a minimum of 10 seconds) ");
        _activityDuration = int.Parse(Console.ReadLine());
    }

    public void Countdown(int numOfSeconds)
    {
        for (int i = numOfSeconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplaySpinner(int numOfSeconds)
    {
        List<string> spinner = new List<string>();
        // spinner.Add("|");
        // spinner.Add("/");
        // spinner.Add("-");
        // spinner.Add("\\");
        // spinner.Add("|");
        // spinner.Add("/");
        // spinner.Add("-");
        // spinner.Add("\\");
        spinner.Add("<>----");
        spinner.Add("-<>---");
        spinner.Add("--<>--");
        spinner.Add("---<>-");
        spinner.Add("----<>");
        spinner.Add(">----<");

        DateTime endTime = (DateTime.Now).AddSeconds(numOfSeconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(200);
            // Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b            \b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("\b\b\b\b\b\b      \b\b\b\b\b\b");

            i++;

            if (i >= spinner.Count())
            {
                i = 0;
            }
        }
    }

    public void EndActivity()
    {
        Console.WriteLine("Well done!");
        DisplaySpinner(5);
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName}.");
        DisplaySpinner(5);
    }

    public int GetTotalSecondsSpent(int numOfTotalSeconds)
    {
        int totalSecondsSpent = numOfTotalSeconds + _activityDuration;
        return totalSecondsSpent;
    }
}
