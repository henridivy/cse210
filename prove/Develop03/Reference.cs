public class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    // or you can say -->
    // private string _book, _chapter, _startVerse, _endVerse;

    public Reference(string book, string chapter, string start)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = "";
    }
    
    public Reference(string book, string chapter, string start, string end)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }

    public string GetReference()
    {
        string reference = "";

        if (_endVerse == "")
        {
            reference = $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        return reference;
    }
}