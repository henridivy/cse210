public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        
    }

    public SimpleGoal(string goalName, string goalDescription, int goalPoints, bool isCompleted) : base(goalName, goalDescription, goalPoints, isCompleted)
    {

    }

    public override void ListGoalInFile(StreamWriter outputFile)
    {
        outputFile.WriteLine($"{GetType()}>>{GetGoalName()}>>{GetGoalDescription()}>>{GetGoalPoints()}>>{GetIsCompleted()}");
    }

    public override void RecordGoal()
    {
        SetIsCompleted(true);
        Console.WriteLine($"You have completed: {GetGoalName()}!");
        base.RecordGoal();
    }
}