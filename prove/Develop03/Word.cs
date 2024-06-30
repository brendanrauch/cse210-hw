using System;

public class Word
{
    private string _text;
    private bool _isHidden; 

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Reveal()
    {
        _isHidden = false;
    }

     public bool IsHidden
    {
        get { return _isHidden; }
    }

    public override string ToString()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}
