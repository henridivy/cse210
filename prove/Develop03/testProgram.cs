// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         IDictionary<Reference, string> scriptures = new Dictionary<Reference, string>();
        
//         Reference moses = new Reference("Moses", "1", "39");
//         Reference nephi = new Reference("2 Nephi", "32", "3");
//         Reference jacob = new Reference("Jacob", "2", "18", "19");

//         scriptures.Add(moses, "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
//         scriptures.Add(nephi, "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.");
//         scriptures.Add(jacob, "But before ye seek for riches, seek ye for the kingdom of God. And after ye have obtained a hope in Christ ye shall obtain riches, if ye seek them; and ye will seek them for the intent to do good—to clothe the naked, and to feed the hungry, and to liberate the captive, and administer relief to the sick and the afflicted.");



//         Console.WriteLine("Welcome to the Scripture Memorizer Program!");
//         Console.WriteLine("Please input the scripture you would like to master.");

//         foreach(KeyValuePair<Reference, string> pair in scriptures)
//         {
//             Console.WriteLine("> " + pair.Key.GetReference());
//         }
//         Console.Write("Scripture: ");
//         string userScripture = Console.ReadLine();

        

        
//     }
// }