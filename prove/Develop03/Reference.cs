using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;
    private string _verses;

    public Reference(string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }
    
    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public Reference(string reference)
    {
        string[] parts = reference.Split(" ");
        _book = parts[0];
        _chapter = parts[1].Split(":")[0];
        string[] verseParts = parts[1].Split(":")[1].Split("-");
        _startVerse = verseParts[0];
        
        if (verseParts.Length == 2)
        {
            _endVerse = verseParts[1];
            _verses = GetVersesNumber(_startVerse, _endVerse);

        }
        else
        {
            _endVerse = null;
            _verses = $"{_startVerse}";
        }
    }

    private string GetVersesNumber(string startVerse, string endVerse)
    {
        _startVerse = startVerse;
        _endVerse = endVerse;
        string verse = $"{startVerse}-{endVerse}";

        return verse;
    }

    public override string ToString()
    {        
        string referenceD = $"{_book} {_chapter}:{_verses}";

        return referenceD;
    }

// Libro Capitulo : Ver1 - Ver2

}