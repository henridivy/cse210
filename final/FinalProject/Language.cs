public class Language
{
    private int _totalPoints = 0;
    protected string _languageName = "";
    protected int _languageIndex = 0;
    private List<Badge> _acquiredBadges = new List<Badge>();

    public void Countdown(int numOfSeconds)
    {
        for (int i = numOfSeconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void SetLanguageName(string languageName, int languageIndex)
    {
        _languageName = languageName;
        _languageIndex = languageIndex;
    }

    public string GetLanguageName()
    {
        return _languageName;
    }

    public int GetLanguageIndex()
    {
        return _languageIndex;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void AddToTotalPoints(int pointsToAdd)
    {
        _totalPoints += pointsToAdd;
    }

    public void AddBadgeToList(Badge acquiredBadge)
    {
        _acquiredBadges.Add(acquiredBadge);
    }

    public void DisplayVocabList()
    {
        string filename = "vocabulary.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string englishWord = parts[0];
            string languageWord = parts[_languageIndex];

            Console.Write($"{englishWord}: {languageWord} \n");
            Console.Read(); Console.Read();
        }
    }

    public void DisplayNumTimeList()
    {
        string filename = "numTime.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string englishWord = parts[0];
            string languageWord = parts[_languageIndex];

            Console.Write($"{englishWord}: {languageWord} \n");
            Console.Read(); Console.Read();
        }
    }

    public void DisplayDatesList()
    {
        string filename = "dates.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string englishWord = parts[0];
            string languageWord = parts[_languageIndex];

            Console.Write($"{englishWord}: {languageWord} \n");
            Console.Read(); Console.Read();
        }
    }

    public void DisplayShortPhrasesList()
    {
        string filename = "shortPhrases.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string englishWord = parts[0];
            string languageWord = parts[_languageIndex];

            Console.Write($"{englishWord}: {languageWord} \n");
            Console.Read(); Console.Read();
        }
    }
}