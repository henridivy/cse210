using System;
public class Scripture
{
    // assign attributes each scripture will have
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    // create a constructor with the reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // use the text to turn each word into an instance of the Word class
        CreateWords(text);
    }

    // method to use turn each word in given text into an instance of the Word class
    private void CreateWords(string text)
    {
        // split the verse into individual words
        string[] textParts = text.Split();

        // for each individual word in the split parts...
        foreach (string word in textParts)
        {
            // create a new instance of the Word class
            Word scriptureWord = new Word(word);
            // add that instance to the list of words
            _words.Add(scriptureWord);
        }
    }

    // method to get and return scripture with or without hidden words
    public string GetScripture()
    {
        // create a variable to store the text as a string
        string scriptureText = "";

        // for each word in the list of words...
        foreach (Word scriptureWord in _words)
        {
            // if the word is hidden...
            if (scriptureWord.GetIsHidden() == true)
            {
                // create an empty string to store the underscores
                string replacedWord = "";
                // for each letter in the word...
                foreach (char letter in scriptureWord.GetWord())
                {
                    // add an underscore in place of the letter
                    replacedWord += "_";
                }

                // add the replaced word (of underscores) to the scripture text
                scriptureText += replacedWord;
            }
            else
            {
                // get the word as a string and add it to the scripture text
                scriptureText += (scriptureWord.GetWord());
            }
            // add a space
            scriptureText += " ";
        } 

        // return the reference and scripture text
        return $"{_reference.GetReference()}: {scriptureText}";
    }
 
    // method to check if all the words in the scripture have been hidden
    public bool IsCompletelyHidden()
    {
        // create an integer that we will use to check
        int check = 0;
        // create a boolean variable that we will use to show if all words are hidden
        bool isCompletelyHidden = false;

        // for each word in the list of words...
        foreach (Word scriptureWord in _words)
        {
            // if the word is hidden
            if (scriptureWord.GetIsHidden() == true)
            {
                // the check stays the same
                check += 0;
            }
            else
            {
                // the check adds one
                check += 1;
            }
        }
        // if the check has stayed 0...
        if (check == 0)
        {
            // then all the words are hidden
            isCompletelyHidden = true;
        }
        return isCompletelyHidden;
    }

    // method to make random words hidden
    public void HideRandomWords()
    {
        // choose randomly 2 or 3 words to hide
        int numWordsToRemove = new Random().Next(2, 4);
        // set the number of words removed this round to 0
        int wordsRemoved = 0;

        // until the number of words removed reaches the number that is supposed to be removed AND the list of words is not completely hidden...
        do
        {
            // choose a random index from the length of the list of words
            int randomIndex = new Random().Next(0, _words.Count());
            // if the word at that index is not hidden...
            if (_words[randomIndex].GetIsHidden() == false)
            {
                // set it to hidden
                _words[randomIndex].SetIsHidden(true);
                // add 1 to the number of words removed this round
                wordsRemoved++;
            }
        }while (wordsRemoved != numWordsToRemove && this.IsCompletelyHidden() == false);
    }
}
