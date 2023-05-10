using System;
public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        CreateWords(text);
    }

    private void CreateWords(string text)
    {
        string[] textParts = text.Split();

        foreach (string word in textParts)
        {
            Word scriptureWord = new Word(word);
            _words.Add(scriptureWord);
        }
    }

    public string GetScripture()
    {
        string scriptureText = "";

        foreach (Word scriptureWord in _words)
        {
            if (scriptureWord.GetIsHidden() == true)
            {
                string replacedWord = "";
                foreach (char letter in scriptureWord.GetWord())
                {
                    replacedWord += "_";
                }

                scriptureText += replacedWord;
            }
            else
            {
                scriptureText += (scriptureWord.GetWord());
            }
            scriptureText += " ";
        } 

        return $"{_reference.GetReference()}: {scriptureText}";
    }
 
    public bool IsCompletelyHidden()
    {
        int check = 0;
        bool isCompletelyHidden = false;
        foreach (Word scriptureWord in _words)
        {
            if (scriptureWord.GetIsHidden() == true)
            {
                check += 0;
            }
            else
            {
                check += 1;
            }
        }
        if (check == 0)
        {
            isCompletelyHidden = true;
        }
        return isCompletelyHidden;
    }

    public void HideRandomWords()
    {
        int numWordsToRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;

        do
        {
            int randomIndex = new Random().Next(0, _words.Count());
            if (_words[randomIndex].GetIsHidden() == false)
            {
                _words[randomIndex].SetIsHidden(true);
                wordsRemoved++;
            }
        }while (wordsRemoved != numWordsToRemove && this.IsCompletelyHidden() == false);
    }
}
