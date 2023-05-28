using System;

public class Word

{
    public string _word;

    public bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public Word(string word, bool hidden)
    {
        _word = word;
        _hidden = hidden;
    }

    public void wordToUnderscore(string hiddenword)
    {
        foreach (char letter in hiddenword)
        {
            Console.Write("_");
        }
    }
}