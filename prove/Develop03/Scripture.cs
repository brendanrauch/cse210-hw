using System;

// Scripture class
public class Scripture
{
    public Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
        _random = new Random();
    }

    public void HideRandomWords(int count)
    {
        var wordsToHide = _words.Where(w => !w._isHidden).OrderBy(w => _random.Next()).Take(count).ToList(); //from ai after a few questions about getting random words to not repeat. this line of code finds word that are not hidden then counts them and sorting them randomly. the w is a lambda expression wich is a place holder for a filter or command and then finnaly turns it back to a list
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w._isHidden);
    }

    public override string ToString()
    {
        return $"{_reference}\n{string.Join(" ", _words)}";
    }
}