using System;
delegate void Printer(string msg);
class Program
{
    static void PrintIt(string msg){ Console.WriteLine("PrintIt: " + msg); }
    static void Main()
    {
        Printer p = PrintIt; // method group conversion (no 'new')
        p("Hello");
    }
}
