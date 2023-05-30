public class VocabQuestion : Question
{
    private int earnedPoints = 0;

    public override int AskQuestion(int totalPoints, int languageIndex, string languageName)
    {
        // read from the text file with vocab list
        string filename = "vocabulary.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        // skip the first line
        lines = lines.Skip(1).ToArray();

        // use Random to get a random index from the number of lines
        var random = new Random();
        int index = random.Next(lines.Count());
        // assign the randomPrompt variable to whatever was in the random index we got
        string randomVocabLine = lines[index];

        string[] parts = randomVocabLine.Split(",");

        // use a random picker to generate what kind of question will be asked
        int option = random.Next(1, 11);

        if (option <= 5)
        {
            string randomWord = parts[languageIndex];
            _question = $"What does '{randomWord}' mean?";
            _answer = parts[0];
            // "What does 'amigo' mean?"
            // answer: friend
        }
        else
        {
            string englishWord = parts[0];
            _question = $"What is '{englishWord}' in {languageName}?";
            _answer = parts[languageIndex];
            // "What is 'house' in Spanish?
            // answer: casa
        }

        // ask the question and get the user's answer
        Console.WriteLine(_question);
        string userAnswer = Console.ReadLine();

        // if the user's answer is correct, earn 5 points, otherwise earn -3 points
        if (userAnswer == _answer)
        {
            earnedPoints = _correctPoints;
            Console.WriteLine("Correct! +5 points");
        }
        else
        {
            earnedPoints = _wrongPoints;
            Console.WriteLine("Wrong! -3 points");
        }

        // return points earned
        return earnedPoints;
    }

}