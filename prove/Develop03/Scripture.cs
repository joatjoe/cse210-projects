using System;

public class Scripture
{
    public List<Word> _words = new List<Word>();
    public Reference _reference;
    
    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }

    public bool IsCompletelyHidden
    {
        get
        {
            return _words.All(word => word._hidden);
        }
    }

    public void HideWords(int count)
    {
        Random random = new Random();
        List<Word> hiddenWords = new List<Word>();

        for (int i = 0; i < count ; i++)
        {
            Word word = _words[random.Next(_words.Count)];

            while (word._hidden) 
            {
                word = _words[random.Next(_words.Count)];
            }
            word._hidden = true;
            hiddenWords.Add(word);

            if (IsCompletelyHidden)
            {
                break;
            }
        }
    }

    public override string ToString()
    {
        string paragraph = String.Join(" ", _words.Select(word => word._hidden ? new string('_', word._word.Length) : word._word));
        return $"{_reference.ToString()}\n{paragraph}";
    }   
}