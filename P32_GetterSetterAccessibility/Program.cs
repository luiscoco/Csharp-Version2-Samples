using System;
class Person
{
    public string Name { get; private set; }
    public Person(string name){ Name=name; }
}
class Program
{
    static void Main()
    {
        Person p=new Person("Irene"); Console.WriteLine(p.Name);
        // p.Name="Other"; // compile error (setter is private)
    }
}
