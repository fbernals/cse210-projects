using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Class and instance testing.");
        Job job1 = new Job();
        Console.WriteLine("Enter company: ");
        job1._company = Console.ReadLine();
        Console.WriteLine("Enter position: ");
        job1._jobTitle = Console.ReadLine();
        Console.WriteLine("Enter start year: ");
        job1._startYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end year: ");
        job1._endYear = int.Parse(Console.ReadLine());

        Job job2 = new Job();
        Console.WriteLine("Enter company: ");
        job2._company = Console.ReadLine();
        Console.WriteLine("Enter position: ");
        job2._jobTitle = Console.ReadLine();
        Console.WriteLine("Enter start year: ");
        job2._startYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end year: ");
        job2._endYear = int.Parse(Console.ReadLine());

                
        /*Console.WriteLine("This is the data you entered: ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        job1.Display();*/
        
        Console.WriteLine("This is the resume test:");
        Resume myResume = new Resume();
        Console.WriteLine("Enter your name:");
        myResume._name = Console.ReadLine();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{myResume._name}");
        Console.WriteLine("List of jobs:");
        myResume.Display();

        Console.ForegroundColor = ConsoleColor.White;

    }
}