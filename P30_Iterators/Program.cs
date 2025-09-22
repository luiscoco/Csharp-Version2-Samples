using System; using System.Collections.Generic;
class Fib
{
    public static IEnumerable<int> Sequence(int count)
    {
        int a=0,b=1;
        for(int i=0;i<count;i++){ yield return a; int t=a+b;a=b;b=t; }
    }
}
class Program
{
    static void Main(){ foreach(int n in Fib.Sequence(5)) Console.WriteLine(n); }
}
