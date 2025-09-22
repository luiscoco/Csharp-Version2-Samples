using System;
class Program
{
    static void Main()
    {
        int? maybe = null; Console.WriteLine("HasValue? " + maybe.HasValue);
        maybe = 42; Console.WriteLine("Value: " + maybe.Value);
        int? a=null; int b=a??99; Console.WriteLine("?? operator: " + b);
    }
}
