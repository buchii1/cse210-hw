using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment newA = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-9");
        Console.WriteLine(newA.GetSummary());
        Console.WriteLine(newA.GetHomeworkList());
        
        Console.WriteLine();

        WritingAssignment newW = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(newW.GetSummary());
        Console.WriteLine(newW.GetWritingInformation());
    }
}