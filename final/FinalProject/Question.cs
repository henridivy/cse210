public class Question
{
    private string _question = "";
    private string _answer = "";
    private int _correctPoints = 0;
    private int _wrongPoints = 0;

    public void AskQuestions(int totalPoints)
    {
        string filename = "vocabulary.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
        

            while (totalPoints < 50)
            {
                Console.WriteLine("");
            }
        }
    }
}