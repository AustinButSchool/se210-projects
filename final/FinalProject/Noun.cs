using System;
using System.ComponentModel.DataAnnotations;

public class Nouns : Word
{

    public Nouns() {

         words = new string[] {"Jake", "ball", "bed", "kite"};
    }
    public override string WordList(Random random)
    {
       

        int randomChoice = random.Next(0, words.Length);

        return words[randomChoice];
    }
    public override string[] Add(){
        Console.WriteLine("What word would you like to add? ");
        tempWord = Console.ReadLine();
        words = words.Append(tempWord).ToArray();
        foreach (string item in words){

            Console.WriteLine(item);
        }
        
        return words;
    }
}