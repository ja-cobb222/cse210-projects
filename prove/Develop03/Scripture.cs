using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Ref { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(Reference reference, string text)
    {
        Ref = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var rnd = new Random();
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count == 0) return;

        for (int i = 0; i < count; i++)
        {
            var word = visibleWords[rnd.Next(visibleWords.Count)];
            word.Hide();
            visibleWords.Remove(word);
            if (visibleWords.Count == 0) break;
        }
    }

    public override string ToString()
    {
        return $"{Ref}\n{string.Join(" ", Words)}";
    }
}