using System;
using System.Collections.Generic;

 class program
{
    static void Main(string[] args)
    { 
        int ajListInput;
        List<int> ajNumList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when done.");
        do{
            Console.Write("Give Me a Number: ");
            ajListInput = int.Parse(Console.ReadLine());
            ajNumList.Add(ajListInput);
        }
        while(ajListInput != 0);
        
        int ajListSum = 0;
        int ajListCount;
        int ajLargestNum = 0;
        int ajSmallNum = 2147483647;

        ajListCount = ajNumList.Count;

        foreach (int i in ajNumList){

            ajListSum = ajListSum + i;
            if (i > ajLargestNum)
            {
                ajLargestNum = i;
            }
            if (i < ajSmallNum && i > 0)
            {
                ajSmallNum = i;
            }
        }
        
        
        Console.WriteLine("Sum: " + ajListSum);

        decimal ajListAverage = Math.Round((decimal) ajListSum / (ajListCount - 1) , 5);
        
        Console.WriteLine("Average: " + ajListAverage);
        Console.WriteLine("Largest: " + ajLargestNum);
        Console.WriteLine("Smallest: " + ajSmallNum);
    }
    }
