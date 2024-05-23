using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public void SetReference(Reference reference)
    {
        _reference = reference;
    }

    public List<Word> GetWords()
    {
        return _words;
    }

    public void SetWords(List<Word> words)
    {
        _words = words;
    }

    public void HideRandomWords(int wordsToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < wordsToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].GetIsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool AreAllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.GetIsHidden())
                return false;
        }
        return true;
    }

    public void Display()
    {
        Console.WriteLine($"{_reference}:");
        foreach (var word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }
}