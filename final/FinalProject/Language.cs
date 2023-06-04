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

    public void DisplayList(string filename)
    {
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

    public int AskFinalExamQuestion()
    {
        var random = new Random();
        int randomNumber = random.Next(5);

        int earnedPoints = 0;

        if (randomNumber == 0)
        {
            // create an instance of the vocab question
            VocabQuestion examQuestion = new VocabQuestion();

            examQuestion.SetCorrectPoints(5);
            examQuestion.SetWrongPoints(-3);

            earnedPoints = examQuestion.AskQuestion(GetTotalPoints(), GetLanguageIndex(), GetLanguageName());
            AddToTotalPoints(earnedPoints);
        }

        else if (randomNumber == 1)
        {
            // create an instance of the numbers and time question
            NumTimeQuestion examQuestion = new NumTimeQuestion();

            examQuestion.SetCorrectPoints(10);
            examQuestion.SetWrongPoints(-7);

            earnedPoints = examQuestion.AskQuestion(GetTotalPoints(), GetLanguageIndex(), GetLanguageName());
            AddToTotalPoints(earnedPoints);
        }

        else if (randomNumber == 2)
        {
            // create an instance of the dates question
            DatesQuestion examQuestion = new DatesQuestion();

            examQuestion.SetCorrectPoints(15);
            examQuestion.SetWrongPoints(-10);

            earnedPoints = examQuestion.AskQuestion(GetTotalPoints(), GetLanguageIndex(), GetLanguageName());
            AddToTotalPoints(earnedPoints);
        }

        else if (randomNumber == 3)
        {
            // create an instance of the short phrases question
            ShortPhrasesQuestion examQuestion = new ShortPhrasesQuestion();

            examQuestion.SetCorrectPoints(20);
            examQuestion.SetWrongPoints(-13);

            earnedPoints = examQuestion.AskQuestion(GetTotalPoints(), GetLanguageIndex(), GetLanguageName());
            AddToTotalPoints(earnedPoints);
        }

        else
        {
            // create an instance of the self-intro question
            SelfIntroQuestion examQuestion = new SelfIntroQuestion();

            examQuestion.SetCorrectPoints(25);
            examQuestion.SetWrongPoints(-18);

            earnedPoints = examQuestion.AskQuestion(GetTotalPoints(), GetLanguageIndex(), GetLanguageName());
            AddToTotalPoints(earnedPoints);
        }

        return earnedPoints;
    }
}