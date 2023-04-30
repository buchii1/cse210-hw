using System;
using System.Collections.Generic;
using System.Linq;

/* Solution 2 uses do while loop and the built-in Max and Sum function from the System.Linq library
   SOlution 1 uses while loop and a custom method of keeping count of the running total and a foreach loop  
   Comment out Solution 1 when done testing, and uncomment Solution 2*/

class Program
{
    static void Main(string[] args)
    {
        // SOLUTION 1
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // An empty list to store the numbers
        List<int> numList = new List<int>();
        // A variable to store the total
        int total = 0;
        // A variable to store the average
        float avg;
        // Variable to store the highest number
        int maxNum = 0;
        // Variable to store the lowest positive num
        int minNum = 99999;
        // Variable to store user input
        int userNum = 999999999;

        while (userNum != 0)
        {
            Console.Write("Enter number: ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                numList.Add(userNum);
            }
        }

        foreach (int num in numList)
        {
            // Add the current number to the running total
            total += num;
            
            // Calculate the maximum number
            if (num > maxNum)
            {
                maxNum = num;
            }

            // Calculate the lowest positive number
            if (num > 0)
            {
                if (num < minNum)
                {
                    minNum = num;
                }
            }
        }

        // Calculate the average
        avg =  (float)total / numList.Count;

        // Display the outputs to the console
        Console.WriteLine($"\nThe sum is: {total}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {maxNum}");
        Console.WriteLine($"The smallest positive number is: {minNum}");
        Console.WriteLine($"The sorted list is:");

        // Sort the list
        numList.Sort();

        // Loop through the sorted list and print
        foreach (int num in numList)
        {
            Console.WriteLine(num);
        }

        /*
        // SOLUTION 2
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // A list to store the inputted numbers
        List<int> numList = new List<int>();
        // Variable to store user input
        int userNum;

        do
        {
            Console.Write("Enter number: ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                numList.Add(userNum);
            }

        } while (userNum != 0);

        // Calculate total
        int total = numList.Sum();

        // Calculating average using two methods:
        // Comment out the method 1, and uncomment method 2 
        // METHOD 1 - using custom method
        float avg = Convert.ToSingle(total) / numList.Count();
        // METHOD 2 - using the List built-in Average method
        // double avg = numList.Average();

        // Calculate maximum number
        int maxNum = numList.Max();

        Console.WriteLine($"\nThe sum is {total}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is {maxNum}");
        */
    }
}