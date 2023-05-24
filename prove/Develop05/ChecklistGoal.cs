public class ChecklistGoal : Goal
{
    private int _bonusPoints = 0;
    private int _numCompleted = 0;
    private int _numTotal = 0;

    public ChecklistGoal()
    {
        
    }

    public ChecklistGoal(string goalName, string goalDescription, int goalPoints, int bonusPoints, int numTotal, int numCompleted) : base(goalName, goalDescription, goalPoints)
    {
        _bonusPoints = bonusPoints;
        _numCompleted = numCompleted;
        _numTotal = numTotal;
    }

    public override void CreateNewGoal()
    {
        base.CreateNewGoal();

        Console.Write("How many times does this goal need to be accomplished for bonus points? ");
        _numTotal = int.Parse(Console.ReadLine());

        Console.Write("How many bonus points will be given for completing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public int GetNumCompleted()
    {
        return _numCompleted;
    }

    public int GetNumLeft()
    {
        return _numTotal;
    }

    public override void DisplayGoal()
    {
        Console.Write(GetGoalCheck());
        Console.Write($" {GetGoalName()} ({GetGoalDescription()})");
        Console.WriteLine($" -- Currently completed: {_numCompleted}/{_numTotal}");
    }

    public override void ListGoalInFile(StreamWriter outputFile)
    {
        outputFile.WriteLine($"{GetType()}>>{GetGoalName()}>>{GetGoalDescription()}>>{GetGoalPoints()}>>{_bonusPoints}>>{_numTotal}>>{_numCompleted}");
    }
}