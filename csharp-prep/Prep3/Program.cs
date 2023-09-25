using System;

 class program
{
    static void Main(string[] args)
    {	string ajGame = "yes";
        while (ajGame == "yes"){
            int ajCount = 0;
            int ajMagicNumber;
        	int ajGuessedNumber;
            Console.WriteLine("Welcome to Higher or Lower!");
            Console.Write("What is the magic number? ");
            ajMagicNumber = int.Parse(Console.ReadLine());
            do {
                Console.Write("What is your number guess? ");
                ajGuessedNumber = int.Parse(Console.ReadLine());
                if (ajGuessedNumber < ajMagicNumber)
                {
                    Console.WriteLine("Your guess is smaller.");
                }
                else if(ajGuessedNumber > ajMagicNumber)
                {
                    Console.WriteLine("Your guess is bigger.");
                }
                else
                {
                    Console.WriteLine("Your guess is right!");
                }
                ajCount++;
            }
            while (ajGuessedNumber != ajMagicNumber);
            Console.WriteLine("You guessed " + ajCount + " times.");
            Console.WriteLine("Would you like to play again? (yes or no.)");
            ajGame = Console.ReadLine();
        }
    }
}