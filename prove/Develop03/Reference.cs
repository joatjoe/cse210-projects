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
        string[] parts01 = reference.Split(" ");
        _book = parts01[0];
        string[] parts02 = parts01[1].Split(":");
        _chapter = parts02[0];
        string[] parts03 = parts02[1].Split("-");
        _startVerse = parts03[0];
        
        if (parts03.Length == 2)
        {
            _endVerse = parts03[1];
            _verses = GetVerse(_startVerse, _endVerse);
        }
        else
        {
            _endVerse = null;
            _verses = $"{_startVerse}";
        }
    }

    private string GetVerse(string startVerse, string endVerse)
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