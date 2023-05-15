using System;
using System.IO;

public class Journal
{
    public List<Entry> entries = new List<Entry>();
    Trigger trigger = new Trigger();    

    public void AddEntry()
    {
        string prompt = trigger.GetPrompt();

        Console.WriteLine($"{prompt} ");
        string answer = Console.ReadLine();

        Console.Write("Do you want to write something else? (Y/N): ");
        string YesNo = Console.ReadLine();
        string userInput = "";

        if (YesNo == "y" || YesNo =="Y") 
        {
            Console.WriteLine("What would you like to add? ");
            userInput = Console.ReadLine();
        }

        Entry newEntry = new Entry {
            _date = DateTime.Now,
            _prompt = prompt,
            _promptEntry = answer,
            _userInput = userInput
        };
        entries.Add(newEntry);
        Console.WriteLine("Saved successfully.");
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            if (entry._userInput == "")
            {
                Console.WriteLine($"Date: {entry._date.ToString("MM/dd/yyyy")} - Prompt: {entry._prompt}");
                Console.WriteLine($"{entry._promptEntry}");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"Date: {entry._date.ToString("MM/dd/yyyy")} - Prompt: {entry._prompt}");
                Console.WriteLine($"{entry._promptEntry}");
                Console.WriteLine($"Peronal thoughts: {entry._userInput}");
                Console.WriteLine("");
            }
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("Please, enter a filename to save (remember to add .txt at the end of the filename): ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
        foreach (Entry entry in entries)
        {
            if (entry._userInput == "")
            {
                outputFile.WriteLine($"Date: {entry._date.ToString("MM/dd/yyyy")} - Prompt: {entry._prompt}");
                outputFile.WriteLine($"{entry._promptEntry}");
                outputFile.WriteLine("");
            }
            else
            {
                outputFile.WriteLine($"Date: {entry._date.ToString("MM/dd/yyyy")} - Prompt: {entry._prompt}");
                outputFile.WriteLine($"{entry._promptEntry}");
                outputFile.WriteLine($"Peronal thoughts: {entry._userInput}");
                outputFile.WriteLine("");
            }
        }
    }
        Console.WriteLine($"Saving your journal in {filename}...");
        Console.WriteLine("Saving successfull.");
    }

    public List<Entry> LoadFromFile()
    {
        Console.WriteLine("Please, enter the filename to load the Journal from: ");
        string filename = Console.ReadLine();
        List<Entry> entries = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(filename);
        Console.WriteLine($"Loading your Journal from {filename}...");

        foreach (string line in lines)
        {
            Console.WriteLine(line);            
        }
        return entries;
    }

}