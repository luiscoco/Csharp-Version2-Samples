using System;
delegate void Printer(string msg);
class Program
{
    static void Main()
    {
        // Delegate inference with anonymous method
        Printer p = delegate(string s){ Console.WriteLine(s.ToUpper()); };
        p("hello inferred delegate");
    }
}
