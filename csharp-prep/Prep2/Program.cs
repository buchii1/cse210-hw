using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a grade
        Console.Write("What is your grade? ");
        string userGrade = Console.ReadLine();
        // Convert the grade to an int
        int grade = int.Parse(userGrade);

        // Variable to store the letter grade
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        // Variable to hold the grade sign
        string sign;
        
        if (grade % 10 >= 7)
        {
            sign = "+";
        }
        else if (grade % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Remove signs for A+ and F grades
        if (grade >= 97 || grade <= 60)
        {
            sign = "";
        }

        // Print the user's letter grade to the terminal
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Check if the user passed or failed the course
        if (grade >= 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else
        {
            Console.WriteLine("Better luck in your next attempt!");
        }
    }
}