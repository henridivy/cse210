using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // string magicNum = Console.ReadLine();
        // int magicNumber = int.Parse(magicNum);

        string continuePlaying = "yes";

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            bool continueGuessing = true;
            int numberOfGuesses = 0;

            do
            {
                Console.WriteLine();
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                int userGuess = int.Parse(guess);

                numberOfGuesses += 1;

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it! ");
                    Console.WriteLine($"It took {numberOfGuesses} tries!");
                    continueGuessing = false;

                    Console.WriteLine();
                    Console.Write("Would you like to play again? ");
                    continuePlaying = Console.ReadLine();
                
                }
            } while (continueGuessing == true);
        } while (continuePlaying == "yes");
        
       
    }
}