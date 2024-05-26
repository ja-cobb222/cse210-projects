using System;

public class Entry
{
    public string _date { get;  set;}
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _promptText = prompt;
        _entryText = response;
    }
    
    public override string ToString()
    {
        return $"Date: {_date} \nPrompt: {_promptText} \nEntry: {_entryText} \n";
    }
}