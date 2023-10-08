<<<<<<< HEAD
using System;

public class Menu
{
    Entries entries = new Entries();
    private SaveAndLoad saveAndLoadHandler = new SaveAndLoad();
    public string userChoice;
    public List<string> _menuList = new List<string>() {"1. Write", "2. Display", "3. Load",
    "4. Save", "5. Quit"};

    public void DisplayMenu(){
    
        string userChoice = "";

        while (userChoice != "5") { 
            Console.WriteLine("\nPlease select one of the following choices:");
            foreach (string option in _menuList)
            {
                Console.WriteLine(option);

            }
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine(); 
            switch (userChoice) {
                
            
                case "1":
                    entries.GetEntry();
                
                break;

                case "2":
                    entries.Display();
                break;

                case "3":
                    entries.entries = saveAndLoadHandler.Load();
                break;

                case "4":

                    saveAndLoadHandler.Save(entries.entries);
                break;

                case "5":
                    Console.WriteLine("\nProgram Closing, come back soon!");
                break;

                default:
                Console.WriteLine("\nInvalid response \nPlease enter a whole number between 1 and 5.");
                break;
            }
=======
/*Journal Program;
This program takes responses from user and 
saves them in a chronological file;
Ryan Holt CopyWright Oct2,2023*/

public class Menu
{
    public string _userChoice;
    public List<string> _menuList = new List<string>() {"1. Write", "2. Display", "3. Load",
    "4. Save", "5. Quit"};

    public void DisplayMenu()
    {
        foreach (string option in _menuList)
        {
            Console.WriteLine(option);

        }
        _userChoice = Console.ReadLine();
        

        switch (_userChoice)
        {
            case "1":
            /*call new entry, not sure where to put the new instance of entry*/
            Console.WriteLine(1);
            break;

            case "2":
            
            Console.WriteLine(2);
            break;

            case "3":
            Console.WriteLine(3);
            break;

            case "4":
            Console.WriteLine(4);
            break;

            case "5":
            Console.WriteLine(5);
            break;

            default:
            Console.WriteLine("Please enter a whole number between 1 and 5.");
            DisplayMenu();
            break;
>>>>>>> 0b695406a02ffb7575608c01f9fdad8fed0d9f95

            
        }
    }

    /*
    public void DisplayFile()
    {

    }

    public string CreateEntry()
    {
        return Entry;
    }

    public 
    */

<<<<<<< HEAD
}
=======
}
>>>>>>> 0b695406a02ffb7575608c01f9fdad8fed0d9f95
