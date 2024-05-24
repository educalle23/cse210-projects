public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> unhiddenWords = new List<Word>();

        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                unhiddenWords.Add(word);
            }
        }

        if (unhiddenWords.Count == 0)
        {
            return;
        }

        List<Word> wordsToHide = new List<Word>();
        for (int i = 0; i < numberToHide && unhiddenWords.Count > 0; i++)
        {
            int index = random.Next(unhiddenWords.Count);
            wordsToHide.Add(unhiddenWords[index]);
            unhiddenWords.RemoveAt(index);
        }

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.ToString() + ": ";
        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.TrimEnd();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}