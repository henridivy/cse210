public class BreathingActivity : Acitivy
{
    public void StartBreathingSequence()
    {
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