using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userNumber = -1;
        List<int> listOfNumbers = new List<int>();

        float sum = 0;
        int maxSoFar = 0;
        int smallestPositive = 1000000;

        do
        {
            Console.Write("Enter number: ");
            string valueInText = Console.ReadLine();
            userNumber = int.Parse(valueInText);

            if (userNumber != 0)
            {
                sum += userNumber;
                listOfNumbers.Add(userNumber);

                if (userNumber > maxSoFar)
                {
                    maxSoFar = userNumber;
                }

                if (userNumber < smallestPositive && userNumber > 0)
                {
                    smallestPositive = userNumber;
                }

            }

        } while (userNumber != 0);
        
        // foreach (int number in listOfNumbers)
        // {
        //     Console.WriteLine(number);
        // }

        int length = listOfNumbers.Count;
        float average = sum / length;
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxSoFar}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is: ");

        List<int> list = new List<int> { 5, 7, 3 };
        listOfNumbers.Sort();
        foreach (int x in listOfNumbers)
        {
            Console.WriteLine(x);
        }
    }
}