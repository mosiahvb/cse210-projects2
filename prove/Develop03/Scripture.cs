public class Scripture
{
    private Reference _reference;
    private Word[] _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordArray = text.Split(' ');
        _words = new Word[wordArray.Length];
        for (int i = 0; i < wordArray.Length; i++)
        {
            _words[i] = new Word(wordArray[i]);
        }
        _random = new Random();
    }

    public void HideTwoWords()
    {
        int visibleWordCount = GetVisibleWordCount();
        if (visibleWordCount <= 1)
            return;

        int index1 = GetRandomVisibleWordIndex();
        _words[index1].Hide();

        int index2 = GetRandomVisibleWordIndex();
        _words[index2].Hide();
    }

    private int GetVisibleWordCount()
    {
        int count = 0;
        foreach (var word in _words)
        {
            if (!word.Hidden())
                count++;
        }
        return count;
    }

    private int GetRandomVisibleWordIndex()
    {
        int visibleWordCount = GetVisibleWordCount();
        int[] visibleWord = new int[visibleWordCount];
        int currentIndex = 0;
        for (int i = 0; i < _words.Length; i++)
        {
            if (!_words[i].Hidden())
            {
                visibleWord[currentIndex] = i;
                currentIndex++;
            }
        }
        int randomIndex = _random.Next(visibleWordCount);
        return visibleWord[randomIndex];
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";

        foreach (var word in _words)
        {
            if (word.Hidden())
                displayText += "----- ";
            else
                displayText += word.GetText() + " ";
        }

        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.Hidden())
                return false;
        }
        return true;
    }
}
