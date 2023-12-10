using System;
using System.ComponentModel.DataAnnotations;

public class Story
{
    public string fullStory(){
        Console.WriteLine("Write a story, and the program will mad lib it!");
        Console.WriteLine("Whenever you get an adjective, use 'adj'.");
        Console.WriteLine("Whenever you get a verb, use 'verb'.");
        Console.WriteLine("Whenever you get an noun, use 'noun'.");
        Console.WriteLine("Example: Hi, I am a adj verb.");
        Console.Write("Your Story:");
        string storyTest = Console.ReadLine();

        string[] words = storyTest.Split(' ');

        Word testWord = new Adjective();
        Word testWord1 = new Nouns();
        Word testWord2 = new Verb();

        for (int i = 0; i < words.Length; i++){
            if (words[i] == "adj"){
                words[i] = testWord.WordList(new Random());
            }
            else if (words[i] == "verb"){
                words[i] = testWord1.WordList(new Random());
            }
            else if (words[i] == "noun"){
                words[i] = testWord2.WordList(new Random());
            }

        }

        storyTest = string.Join(" ", words);

        return storyTest;
}
}