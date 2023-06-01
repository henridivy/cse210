public abstract class Badge
{
    protected List<string> _design;


    public abstract void CreateBadge();

    public void DisplayBadge()
    {
        foreach(string line in _design)
        {
            Console.WriteLine(line);
        }
    }
}