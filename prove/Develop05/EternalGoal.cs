public class EternalGoal : Goal
{
    private int _howManyTimes = 0;

    public EternalGoal()
    {
        
    }

   public EternalGoal(string goalName, string goalDescription, int goalPoints, int howManyTimes) : base(goalName, goalDescription, goalPoints)
    {
        _howManyTimes = howManyTimes;
    }

    public override string GetGoalCheck()
    {
        if (_howManyTimes > 0)
        {
            return $"[{_howManyTimes}]";
        }
        else
        {
            return "[ ]";
        }
    }

    public override void RecordGoal()
    {
        _howManyTimes++;
        base.RecordGoal();
    }

    public override void ListGoalInFile(StreamWriter outputFile)
    {
        outputFile.WriteLine($"{GetType()}>>{GetGoalName()}>>{GetGoalDescription()}>>{GetGoalPoints()}>>{_howManyTimes}");
    }
}