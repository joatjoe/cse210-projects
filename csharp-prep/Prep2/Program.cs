using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade percentage? ");
        string percentage_s = Console.ReadLine();
        int percentage_i = int.Parse(percentage_s);

        string letter = "";

        if (percentage_i >= 90)
        {
            letter = "A";
        }

        else if (percentage_i >= 80)
        {
            letter = "B";
        }
        
        else if (percentage_i >= 70)
        {
            letter = "C";
        }
        
        else if (percentage_i >= 60)
        {
            letter = "D";
        }
        
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percentage_i >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        
        else
        {
            Console.WriteLine("Sorry, better luck next time!");
        }

    }
}