using System; using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> nums = new List<int>{1,2,3};
        nums.ForEach(delegate(int n){ Console.WriteLine("Square: " + (n*n)); });
    }
}
