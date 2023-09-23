using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        //Initiates a reference variable to indicate if the iterative function will keep adding jobs
        bool keepAdding = true;
        Console.WriteLine("Class and instance testing.");
        //instantiates a new resume object
        Resume myResume = new Resume();
        //Iteration that allows you to add as many jobs as you want while bollean value is true
        while (keepAdding){
            //Instantiates a new job object
            Job job = new Job();
            Console.WriteLine("Enter company: ");
            job._company = Console.ReadLine();
            Console.WriteLine("Enter position: ");
            job._jobTitle = Console.ReadLine();
            Console.WriteLine("Enter start year: ");
            job._startYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end year: ");
            job._endYear = int.Parse(Console.ReadLine());
            //Adds current job to the list
            myResume._jobs.Add(job);
            //Ask the user if he wants to keep adding jobs, if not, changes boolean to false.
            Console.WriteLine("Add another job? (Y/N)");
            string selection = Console.ReadLine().ToLower();
            
            if (selection == "n"){
                keepAdding = false;
            }
            
            
            
        }
        

        
                
        /*Console.WriteLine("This is the data you entered: ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        job.Display();*/
        
        //Console.WriteLine("This is the resume test:");
        
        Console.WriteLine("Enter your name:");
        myResume._name = Console.ReadLine();
        //myResume._jobs.Add(job);
        //myResume._jobs.Add(job2);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{myResume._name}");
        Console.WriteLine("List of jobs:");
        myResume.Display();

        Console.ForegroundColor = ConsoleColor.White;

    }
}