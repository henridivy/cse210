public class Goal
{
    private string _goalName = "";
    private string _goalDescription = "";
    private int _goalPoints = 0;
    private string _goalCheck = "[ ]";
    private bool _isCompleted = false;

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

}
