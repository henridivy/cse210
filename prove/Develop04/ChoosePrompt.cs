// using System;

// public class ChoosePrompt
// {
//     public List<string> _reflectionPrompts = new List<string>();
    
//     public string ChooseFromFile(string filename)
//     {
//         // read from the text file with prompts
//         string[] lines = System.IO.File.ReadAllLines(filename);

//         // add each line (prompt) from the text file to the list of prompts
//         foreach (string line in lines)
//         {
//             _reflectionPrompts.Add(line);
//         }

//         // use Random to get a random index from the length of the prompts list
//         var random = new Random();
//         int index = random.Next(_reflectionPrompts.Count);
//         // assign the randomPrompt variable to whatever was in the random index we got
//         string randomPrompt = _reflectionPrompts[index];

//         return randomPrompt;
//     }
// }