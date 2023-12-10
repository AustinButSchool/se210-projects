using System;
using System.ComponentModel.DataAnnotations;

public class Excuse
{
    public static void ListExcuse(){
    Word adjWord = new Adjective();
    Word nounWord = new Nouns();
    Word verbWord = new Verb();
    string line;
    List<string> excuses = new List<string>() {$"Sorry to talk and {verbWord.WordList(new Random())}, but a {adjWord.WordList(new Random())} {nounWord.WordList(new Random())} is requesting my attention.", $"My dearest apologies, it appears that my {adjWord.WordList(new Random())} {nounWord.WordList(new Random())} has {verbWord.WordList(new Random())} away, and I must go find it.", $"I couldn't even {verbWord.WordList(new Random())} when {nounWord.WordList(new Random())} {verbWord.WordList(new Random())} by, it was a {adjWord.WordList(new Random())} surprise."};
    
    Random random = new Random();
    line = excuses[random.Next(0, 3)];
    Console.WriteLine(line);
    }
}