/*
Name: Jounral Program
Purpose: Entry Part, For Now
Authors: Austin Jones
Code: ©2023*/

using System;
using System.Collections.Generic;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        Entry();
    }
    public static List<string> Entry()
    {
        string ajInput;

        List<string> ajEntry = new List<string>();
        List<string> ajPrompt = new List<string> {"Prompt 1","Prompt 2","Prompt 3","Prompt 4","Prompt 5","Prompt 6"};
        
        
        //Snag the Date
        Console.Write("What is the date? ");
        ajInput = Console.ReadLine();
        ajEntry.Add(ajInput);

        for (int ajI = 0; ajI < 5; ajI++)
        {
            Console.Write("Your Prompt Is: ");
            var ajRandom = new Random();
            int ajIndex = ajRandom.Next(ajPrompt.Count);
            Console.WriteLine(ajPrompt[ajIndex]);
            ajEntry.Add(ajPrompt[ajIndex]);
            ajPrompt.RemoveAt(ajIndex);


            //Snag the Response
            Console.Write("What is the response? ");
            ajInput = Console.ReadLine();
            ajEntry.Add(ajInput);
        }
        

        
        foreach (string value in ajEntry)
        {
            Console.Write($"{value}, ");
        }

        return ajEntry;
    }
}
