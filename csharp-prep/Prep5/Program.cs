using System;

 class program
{
    
    
    static void Main(string[] args)
    {
    DisplayWelcome();
    string ajUserName = PromptUserName();
    int ajUserNumber = PromptUserNumber();
    int ajUserNumberSquared = SquareNumber(ajUserNumber);
    DisplayResult(ajUserName, ajUserNumberSquared);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome To The Program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string ajName = Console.ReadLine();
        
        return ajName;
    }
    
    static int PromptUserNumber()
    {
        Console.Write("What is your number? ");
        int ajNumber = int.Parse(Console.ReadLine());
        
        return ajNumber;
    }

    static int SquareNumber(int ajNumberInput)
    {
        int ajNumberSquared = ajNumberInput * ajNumberInput;
        
        return ajNumberSquared;
    }
    
    static void DisplayResult(string ajPrintName, int ajPrintNumber)
    {
        Console.WriteLine("Your name is: " + ajPrintName);
        Console.Write("Your number squared: " + ajPrintNumber);

    }
}
