using System;
partial class Greeter
{
    public void SayHello() { Console.WriteLine("Hello from part 1"); }
}
partial class Greeter
{
    public void SayBye() { Console.WriteLine("Bye from part 2"); }
}
class Program
{
    static void Main() { Greeter g=new Greeter(); g.SayHello(); g.SayBye(); }
}
