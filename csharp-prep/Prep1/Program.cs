using System;

class Program
{
    static void Main(string[] args)
    {
         // ask the user his name
        Console.Write("Hello What is your first name? ");
        string name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last=Console.ReadLine();
        Console.WriteLine($"your name is {last},{name} {last}");
        Console.WriteLine("Thanks");
    }
}