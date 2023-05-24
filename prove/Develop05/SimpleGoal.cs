public class SimpleGoal : Goal
{
    public override void ListGoalInFile(StreamWriter outputFile)
    {
        outputFile.WriteLine($"{GetType()}>>{GetGoalName()}>>{GetGoalDescription()}>>{GetGoalPoints()}>>{GetIsCompleted}");
    }
}