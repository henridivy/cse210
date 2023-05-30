public class Language
{
    private int _totalPoints = 0;
    protected string _languageName = "";
    protected int _languageIndex = 0;

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
}