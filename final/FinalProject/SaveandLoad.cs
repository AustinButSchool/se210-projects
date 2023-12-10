using System;
using System.ComponentModel.DataAnnotations;

public class SaveLoad
{   
    string genericFile = "save.txt";
    bool pass = false;
    string answer;
    string filePath;
    

    public string[] Load(){
        filePath = genericFile;
        
        while (pass == false) {
        Console.WriteLine("Would you likke to use the basic file? (y/n) ");
        answer = Console.ReadLine();
        switch(answer){
            case "y":
            Console.WriteLine($"Using {genericFile}");
            pass = true;
            break;

            case "n":
            Console.WriteLine("What is the file name and extention of the save file?");
            filePath = Console.ReadLine();
            pass = true;
            break;
            
        }}
        
        pass = false;
        string[] lines = System.IO.File.ReadAllLines(filePath);

        return lines;

    }
    public string Save(String latest){
        filePath = genericFile;
        
        while (pass == false) {
        Console.WriteLine("Would you likke to use the basic file? (y/n) ");
        answer = Console.ReadLine();
        switch(answer){
            case "y":
            Console.WriteLine($"Using {genericFile}");
            pass = true;
            break;

            case "n":
            Console.WriteLine("What is the file name and extention of the save file?");
            filePath = Console.ReadLine();
            pass = true;
            break;
            
        }
        }
        
        pass = false;

        using (StreamWriter outputFile = new StreamWriter(filePath, true)){

        outputFile.WriteLine(latest);
        }
        
        string doneMessage = $"Saved to {filePath}.";
        return doneMessage;
    }

}