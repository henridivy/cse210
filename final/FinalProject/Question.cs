public abstract class Question
{
    protected string _question = "";
    protected string _answer = "";
    protected int _correctPoints = 0;
    protected int _wrongPoints = 0;

    public abstract int AskQuestion(int totalPoints, int languageIndex, string languageName);

    public void SetCorrectPoints(int points)
    {
        _correctPoints = points;
    }

    public int GetCorrectPoints()
    {
        return _correctPoints;
    }

    public void SetWrongPoints(int points)
    {
        _wrongPoints = points;
    }

    public int GetWrongPoints()
    {
        return _wrongPoints;
    }
}