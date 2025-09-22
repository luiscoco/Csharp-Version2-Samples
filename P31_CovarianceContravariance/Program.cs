using System; using System.Collections.Generic;
class Program
{
    static void Main()
    {
        IEnumerable<string> strings = new List<string>{"a","b"};
        IEnumerable<object> objs = strings; // covariance
        foreach(object o in objs) Console.WriteLine(o);
    }
}
