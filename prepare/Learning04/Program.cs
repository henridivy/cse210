using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Jodi Bennett", "History");
        Assignment assign2 = new Assignment("Kim Park Joon", "Spanish");

        Console.WriteLine(assign1.GetSummary());
        Console.WriteLine();

        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssign1 = new MathAssignment("Obodoye Alex", "Percentages", "8.2", "1-5");

        Console.WriteLine(mathAssign1.GetSummary());
        Console.WriteLine(mathAssign1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writeAssign1 = new WritingAssignment("Paula de Santos", "Literature", "Shakespeares Writing Style");

        Console.WriteLine(writeAssign1.GetSummary());
        Console.WriteLine(writeAssign1.GetWritingInfo());
        Console.WriteLine();

        string myName = "Henrietta Gabriel";
        MathAssignment myMath = new MathAssignment(myName, "Order of Operations", "5B", "1-10");
        WritingAssignment myWriting = new WritingAssignment(myName, "Human Evolution", "Molding Homonins Into Homosapiens");

        Console.WriteLine(myMath.GetSummary());
        Console.WriteLine(myMath.GetHomeworkList());
        Console.WriteLine(myWriting.GetSummary());
        Console.WriteLine(myWriting.GetWritingInfo());

    }
}