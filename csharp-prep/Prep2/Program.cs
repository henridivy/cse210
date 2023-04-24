using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int userGrade = int.Parse(userInput);

        string letter = "";

        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B";

        }
        else if (userGrade >= 70)
        {
            letter = "C";
        }
        else if (userGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (userGrade >= 70)
        {
            Console.WriteLine("You passed the course. Congratulations!");
        }
        else
        {
            Console.WriteLine("You didn't pass the course. Better luck next time.");
        }

        Console.Write(userInput[1]);
    }
}