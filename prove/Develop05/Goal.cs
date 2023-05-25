public class Goal
{
    private string _goalName = "";
    private string _goalDescription = "";
    private int _goalPoints = 0;
    private string _goalCheck = "[ ]";
    private bool _isCompleted = false;

    public Goal()
    {

    }

    public Goal(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    public Goal(string goalName, string goalDescription, int goalPoints, bool isCompleted)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _isCompleted = isCompleted;
    }

    public virtual void CreateNewGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();

        Console.Write("How many points are associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public virtual int GetGoalPoints()
    {
        return _goalPoints;
    }

    public void SetIsCompleted(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }

    public bool GetIsCompleted()
    {
        return _isCompleted;
    }

    public string GetGoalCheck()
    {
        if (_isCompleted == true)
        {
            _goalCheck = "[X]";
        }

        return _goalCheck;
    }

    public virtual void DisplayGoal()
    {
        Console.Write(GetGoalCheck());
        Console.Write($" {GetGoalName()} ({GetGoalDescription()})");
    }

    public virtual void ListGoalInFile(StreamWriter outputFile)
    {
        outputFile.WriteLine($"{GetType()}>>{_goalName}>>{_goalDescription}>>{_goalPoints}");
    }

    public virtual void RecordGoal()
    {
        // FOR SIMPLE GOAL
        // set is completed to true

        // FOR CHECKLIST GOAL
        // add 1 to numCompleted
        // if numcompleted == numtotal, set is completed to true
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
    }

}
