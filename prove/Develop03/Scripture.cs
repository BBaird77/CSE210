using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private ScriptureReference Reference { get; }
    private List<Word> Words { get; }
    private Random random = new Random();

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public string GetDisplayText()
    {
        return $"{Reference}{string.Join(" ", Words)}";
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count == 0) return;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}

