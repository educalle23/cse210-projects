using System;
using System.Collections.Generic;


public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }

    public void Hide()
    {
        SetIsHidden(true);
    }

    public string Display()
    {
        return GetIsHidden() ? new string('_', GetText().Length) : GetText();
    }
}
