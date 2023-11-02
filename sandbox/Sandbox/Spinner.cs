using System;
using System.Threading;

class Spinner
{
    private void Start()
    {
    
        Console.CursorVisible = false;
        while (true)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("/");
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write("-");
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write("\\");
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write("|");
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
    }
    public void GetSpinner(){
        Start();
    }
}


