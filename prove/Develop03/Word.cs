public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }
    
    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public string GetWord()
    {
        return _word;
    }
}