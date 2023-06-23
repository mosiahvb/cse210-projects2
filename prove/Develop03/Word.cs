
public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool Hidden()
    {
        return _hidden;
    }

    public string GetText()
    {
        return _hidden ? "___" : _text;
    }
}