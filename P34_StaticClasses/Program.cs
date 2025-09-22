using System;
static class MathHelper
{
    public static int Square(int x){ return x*x; }
}
class Program
{
    static void Main(){ Console.WriteLine(MathHelper.Square(4)); }
}
