public class ChecklistGoal : Goal
{
    private int _bonusPoints = 0;
    private int _numCompleted = 0;
    private int _numLeft = 0;

    public override void CreateNewGoal()
    {
        base.CreateNewGoal();

        Console.Write("How many times does this goal need to be accomplished for bonus points? ");
        _numLeft = int.Parse(Console.ReadLine());

        Console.Write("How many bonus points will be given for completing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public int GetNumCompleted()
    {
        return _numCompleted;
    }

    public int GetNumLeft()
    {
        return _numLeft;
    }

    public override void DisplayGoal()
    {
        base.DisplayGoal();

        Console.WriteLine($" -- Currently completed: {_numCompleted}/{_numLeft}");
    }
}