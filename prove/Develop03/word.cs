using System.Runtime.CompilerServices;

public class Word
{
    private string _text;
    private bool _isHidden;
    private string _hiddenText;

    public Word(string text)
    {
       _text = text;
       _isHidden = false;
       
       foreach(char _ in _text)
       {
            _hiddenText += " _ ";
       }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? _hiddenText : _text;
    }

}