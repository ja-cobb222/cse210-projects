using System;

public class Entry
{
    public string _date { get; }
    public string _promptText { get; }
    public string _entryText { get; }

    public Entry(string _date, string _promptText, string _entryText)
    {
        _date = _date;
        _promptText = _promptText;
        _entryText = _entryText;
    }
    
    public override string ToString()
    {
        return $"Date: {_date} \nPrompt: {_promptText} \nEntry: {_entryText} \n";
    }
}