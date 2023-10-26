using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Fabian", "History");
        MathAssignment mathAssignment1 = new MathAssignment("Fabian", "Math", "7.3", "calculus");
        WritingAssignment writingAssignment = new WritingAssignment("Fabian", "World War II", "Propaganda effect");
        
        
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetMathSummary());
        Console.WriteLine(writingAssignment.GetWritingSummary());
    }
}