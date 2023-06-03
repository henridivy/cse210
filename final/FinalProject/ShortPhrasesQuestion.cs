public class ShortPhrasesQuestion : Question
{
    private int earnedPoints = 0;

    public override int AskQuestion(int totalPoints, int languageIndex, string languageName)
    {
        // read from the text file with vocab list
        string filename = "shortPhrases.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        // skip the first line
        lines = lines.Skip(1).ToArray();

        // use Random to get a random index from the number of lines
        var random = new Random();
        int index = random.Next(lines.Count());
        // assign the randomPrompt variable to whatever was in the random index we got
        string randomLine = lines[index];

        string[] parts = randomLine.Split(",");

        // use a random picker to generate what kind of question will be asked
        int option = random.Next(1, 11);

        if (option <= 5)
        {
            string randomWord = parts[languageIndex];
            _question = $"Translate '{randomWord}':";
            _answer = parts[0];
            // "Translate 'Comment allez-vous':"
            // answer: Sunday
        }
        else
        {
            string englishWord = parts[0];
            _question = $"How do you say '{englishWord}' in {languageName}?";
            _answer = parts[languageIndex];
            // "How do you say 'sorry' in French?
            // answer: demain
        }

        // ask the question and get the user's answer
        Console.WriteLine(_question);
        string userAnswer = Console.ReadLine();

        // if the user's answer is correct, earn 15 points, otherwise earn -10 points
        if (userAnswer == _answer)
        {
            earnedPoints = _correctPoints;
            Console.WriteLine("Correct! +15 points");
        }
        else
        {
            earnedPoints = _wrongPoints;
            Console.WriteLine("Wrong! -10 points");
        }

        // return points earned
        return earnedPoints;
    }

}