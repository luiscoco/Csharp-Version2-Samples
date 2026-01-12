using System; using System.Collections.Generic;
class Program
{
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a; a = b; b = temp;
    }
    static void Main()
    {
        List<int> numbers = new List<int>(); numbers.Add(1); numbers.Add(2);
        foreach(int n in numbers) Console.WriteLine(n);
        int x=5,y=10; Swap(ref x, ref y); Console.WriteLine("x="+x+", y="+y);
    }
}
