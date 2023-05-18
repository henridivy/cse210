public class BreathingActivity : Acitivy
{
    public void StartBreathingSequence()
    {
        Console.Clear();
        Console.Write("Get ready");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1500);
        }
        Console.WriteLine();
        Console.WriteLine();

        int secondsSoFar = 0;
        int duration = GetActivityDuration();

        while (secondsSoFar < duration)
        {
            Console.Write("Breathe in... ");
            Countdown(5);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            Countdown(5);
            Console.WriteLine();
            Console.WriteLine();

            secondsSoFar += 10;
        }
    }
}