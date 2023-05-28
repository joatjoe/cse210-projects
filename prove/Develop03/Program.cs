using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string file = "MPOldTestament.txt";
        List<Scripture> scriptureList = new List<Scripture>();
        scriptureList = GetScriptureMasteryList(file);
        Scripture scripture = GetScripture(scriptureList);

        Console.Clear();
        Console.WriteLine(scripture.ToString());

        string input = "";

        do
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            input = Console.ReadLine();

            if (input != "quit")
            {
                scripture.HideWords(3);

                Console.Clear();
                Console.WriteLine(scripture.ToString());
            }
        } while (input != "quit" && !scripture.IsCompletelyHidden);
    }

    static List<Scripture> GetScriptureMasteryList(string file)
    {
        List<Scripture> scriptureMasteryList = new List<Scripture>();        
        
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(new string[] { "~~~" }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    string reference = parts[0];
                    string text = parts[1];
                    Scripture newScripture = new Scripture(reference, text);
                    scriptureMasteryList.Add(newScripture);
                }
            }
        }
        return scriptureMasteryList;
    }

    static Scripture GetScripture(List<Scripture> scriptureMasteryList)
    {
        Random random = new Random();
        int index = random.Next(scriptureMasteryList.Count);
        Scripture scripture = scriptureMasteryList[index];

        return scripture;
    }
}