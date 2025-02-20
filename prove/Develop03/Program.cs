using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new ScriptureReference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding; " +
                "in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new ScriptureReference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, " +
                "that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new ScriptureReference("1 Nephi", 3, 7),
                "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.")
        };

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
                break;
            
            scripture.HideRandomWords(3); 
        }
    }
}