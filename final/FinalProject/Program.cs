using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {   
        int choice = 0;
        string wordChoice;
        Word adjWord = new Adjective();
        Word nounWord = new Nouns();
        Word verbWord = new Verb();;
        Story story = new Story();
        SaveLoad saveandload = new SaveLoad();
        string latest = "NOTHING"; 


        while (choice != 7){
            Console.WriteLine("Welcome to the word generator! Please say what you want to generate!");
            Console.WriteLine("1. Drawing Prompt");
            Console.WriteLine("2. Funny Excuse Generator");
            Console.WriteLine("3. Story Creator");
            Console.WriteLine("4. Save to file");
            Console.WriteLine("5. Display all from file");
            Console.WriteLine("6. Add word to random list of words");
            Console.WriteLine("7. End");
            choice = int.Parse(Console.ReadLine());
            
            switch (choice) {
                case 1:
                    latest = adjWord.WordList(new Random()) + " " +nounWord.WordList(new Random());
                    Console.WriteLine($"A very {latest}");
                break;

                case 2:
                    Excuse.ListExcuse();
                break;

                case 3:
                    latest = story.fullStory();
                    Console.WriteLine(latest);
                break;

                case 4:
                    saveandload.Save(latest);
                break;
                
                case 5:
                    string[] printFrom = saveandload.Load();
                    foreach (string item in printFrom){
                        Console.WriteLine(item);
                    }
                break;

                case 6:
                    Console.WriteLine("Which word type would you like to add?");
                    Console.WriteLine("1. Adjective");
                    Console.WriteLine("2. Verb");
                    Console.WriteLine("3. Noun");
                    Console.WriteLine("Type anything else to escape.");
                    Console.WriteLine("Choose 1, 2, 3, or anything else.");
                    wordChoice = Console.ReadLine();
                    switch(wordChoice) 
                    {
                        case "1":
                            adjWord.Add();
                        break;
                        case "2":
                            verbWord.Add();
                        break;
                        case "3":
                            nounWord.Add();
                        break;


                        default:
                            Console.WriteLine("Exiting.");
                        break;
                    }
                    
                break;

                case 7:
                    Console.WriteLine("Shutting down the program!");
                break;

                default:
                    Console.WriteLine("Please choose something that is a choice.");
                break;
            }
    }
    }
}