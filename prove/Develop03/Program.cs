using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Console.WriteLine("Please choose the scripture you would like to master.");
        Console.WriteLine();

        // List<string> _menu = new List<string>
        // {
        //     "1. Moses 1:39",
        //     "2. "
        // };

        IDictionary<Reference, string> scriptures = new Dictionary<Reference, string>();
        
        Reference moses = new Reference("Moses", "1", "39");

        scriptures.Add(
            moses, "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."
            );
    }
}