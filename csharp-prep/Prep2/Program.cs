using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter percentage grade: ");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade = "F";
        string plusMinus = "+";

        if (grade >= 90)
        {
           letterGrade = "A"; 
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "c";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            Console.WriteLine("You failed the course.");
        }

        if (grade >= 60 && grade <= 93)
        {
            if (grade % 10 <= 3)
            {
                plusMinus = "-";
            }
            else
            {
                plusMinus = "+";
            }
            
            
        }
        Console.WriteLine($"Your letter grade is {letterGrade}{plusMinus}.");
    }
}