public class Language
{
    private int _totalPoints = 0;
    private string _languageName = "";
    protected int _languageIndex = 0;

    public void SetLanguageName(string languageName, int languageIndex)
    {
        _languageName = languageName;
        _languageIndex = languageIndex;
    }

    public string GetLanguageName()
    {
        return _languageName;
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