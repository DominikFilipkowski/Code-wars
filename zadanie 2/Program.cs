using System;
using System.Linq;

public class Kata
{
    public static int FindSmallestInt(int[] args)
    {
        return args.Min();
    }
}

public class Program
{
    public static void Main()
    {
        int[] args = { 12, 24, 12, 25 };
        int SmallestNum = Kata.FindSmallestInt(args);
        Console.WriteLine(SmallestNum);
    }
}


