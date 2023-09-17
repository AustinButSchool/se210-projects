using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name? ");
        string ajFirst = Console.ReadLine();
        Console.Write("What is your last name? ");
        string ajLast = Console.ReadLine();
        Console.WriteLine($"Your name is {ajLast}, {ajFirst} {ajLast}");
    }
}