using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What grade percentage did you get? ");
        string ajPercentageString = Console.ReadLine();
        float ajPercentage = float.Parse(ajPercentageString);
        string ajLetter = "";
        if (ajPercentage > 90)
        {
        ajLetter = "A";
        if (ajPercentage < 93)
        {
            ajLetter = ajLetter + "-";
        }
        }
        else if (ajPercentage > 80)
        {
        ajLetter = "B";
        if (ajPercentage < 83)
        {
            ajLetter = ajLetter + "-";
        }
        else if (ajPercentage > 87)
        {
            ajLetter = ajLetter + "+";
        }
        }
        else if (ajPercentage > 70)
        {
        ajLetter = "C";
        if (ajPercentage < 73)
        {
            ajLetter = ajLetter + "-";
        }
        else if (ajPercentage > 77)
        {
            ajLetter = ajLetter + "+";
        }
        }
        else if (ajPercentage > 60)
        {
        ajLetter = "D";
        if (ajPercentage < 63)
        {
            ajLetter = ajLetter + "-";
        }
        else if (ajPercentage > 67)
        {
            ajLetter = ajLetter + "+";
        }
        }
        else if (ajPercentage < 60)
        {
        ajLetter = "F";
        }
        Console.WriteLine($"Your letter grade is: {ajLetter}");
        if (ajPercentage < 70)
        {
            Console.WriteLine("Sorry Charlie, you didn't pass. You got it next time.");
        }
        else
        {
            Console.WriteLine("Winner winner, you passed!");
        }


    }
}