using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program!");
        int option = -1;
        do
        {        
            Console.WriteLine("Please, select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
                       
            option = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (option)
            {
                case 1:
                    journal.AddEntry();
                    break;

                case 2:
                    journal.DisplayEntries();
                    break;

                case 3:
                    journal.SaveToFile();
                    break;

                case 4:
                    journal.LoadFromFile();
                    break;
                
                case 5:
                    Console.WriteLine("Bye, see you later!");
                    break;

                default:
                    Console.WriteLine("That's not a valid option.");
                    break;
            }
        } while (option != 5);
    }
}