public class SelfIntroQuestion : Question
{
    private int earnedPoints = 0;

    public override int AskQuestion(int totalPoints, int languageIndex, string languageName)
    {
        // read from the text file with vocab list
        string filename = "selfIntro.txt";
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
            _question = $"What is '{randomWord}' in English?";
            _answer = parts[0];
            // "What is 'Ego de Sinis' in English?"
            // answer: I am from China
        }
        else
        {
            string englishWord = parts[0];
            _question = $"Translate this sentence to {languageName}: '{englishWord}'";
            _answer = parts[languageIndex];
            // "Translate this sentence to Latin: 'My favourite color is green'
            // answer: Ventus color viridis
        }

        // ask the question and get the user's answer
        Console.WriteLine(_question);
        string userAnswer = Console.ReadLine();

        // if the user's answer is correct, earn 25 points, otherwise earn -18 points
        if (userAnswer == _answer)
        {
            earnedPoints = _correctPoints;
            Console.WriteLine("Correct! +25 points");
        }
        else
        {
            earnedPoints = _wrongPoints;
            Console.WriteLine("Wrong! -18 points");
        }

        // return points earned
        return earnedPoints;
    }

}