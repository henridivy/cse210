public class Word
{
    // assign attributes each word will have
    private string _word;
    private bool _isHidden;

    // create a constructor with the given word
    public Word(string word)
    {
        _word = word;
        // make it not hidden
        _isHidden = false;
    }

    // method to make the word hidden or not
    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }
    
    // method to return whether the word is hidden or not
    public bool GetIsHidden()
    {
        return _isHidden;
    }

    // method to return the word as a string
    public string GetWord()
    {
        return _word;
    }
}