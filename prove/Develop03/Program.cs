namespace scripture;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();

        
        library.AddScripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart...");
        library.AddScripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart...");
        library.AddScripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart...");
        library.AddScripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart...");
        library.AddScripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart...");
        library.AddScripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart...");

        while (true)
        {
            Console.Clear();
            Scripture scripture = library.SelectRandomScripture();

            if (scripture != null)
            {
                bool memorized = false;

                while (!scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.RenderScripture());

                    Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        return;

                    scripture.HideRandom();

                    if (scripture.IsCompletelyHidden())
                    {
                        memorized = true;
                        break;
                    }
                }

                if (memorized)
                {
                    Console.Clear();
                    Console.WriteLine("You've memorized the entire scripture!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("The scripture library is empty. Add scriptures or load them from files.");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                return;
            }
        }
    }
}
