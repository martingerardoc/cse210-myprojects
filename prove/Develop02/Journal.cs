using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
     static List<string> journalEntries = new List<string>();
    static void Main(string[] args)
    {
      bool running = true;
        while (running)
        {
            Console.WriteLine("Please choose an option from the menu:");
            Console.WriteLine("1. Respond to a random prompt and save it as an entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Please enter your response to the prompt:");
                    string entry = Console.ReadLine();
                    journalEntries.Add(entry);
                    Console.WriteLine("Entry saved.");
                    break;
                case "2":
                    Console.WriteLine("Journal Entries:");
                    foreach (string journalEntry in journalEntries)
                    {
                        Console.WriteLine(journalEntry);
                    }
                    break;
                case "3":
                    Console.WriteLine("Please enter the file name to save the journal to:");
                    string fileName = Console.ReadLine();
                    File.WriteAllLines(fileName, journalEntries);
                    Console.WriteLine("Journal saved to file.");
                    break;
                case "4":
                    Console.WriteLine("Please enter the file name to load the journal from:");
                    fileName = Console.ReadLine();
                    if (File.Exists(fileName))
                    {
                        journalEntries = new List<string>(File.ReadAllLines(fileName));
                        Console.WriteLine("Journal loaded from file.");
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1-5.");
                    break;
            }
        }

        Console.WriteLine("Exiting program. Press any key to continue...");
        Console.ReadKey();
    }
}