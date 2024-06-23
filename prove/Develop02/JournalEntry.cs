using System;

public class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;


    public JournalEntry(string date,string prompt,string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public override string ToString()
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }
}