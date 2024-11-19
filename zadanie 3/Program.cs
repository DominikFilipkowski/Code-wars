using System;
using System.Linq;
public static class Kata1
{
    public static int ArrayPlusArray(int[] arr1, int[] arr2)
    {
        return arr1.Sum() + arr2.Sum();
    }
}

public class Program
{
    public static void Main()
    {
        int[] arr1 = { 12, 24, 12, 25 };
        int [] arr2 = { 1,24, 13, 40 };

        int TotalSum = Kata1.ArrayPlusArray(arr1, arr2);
        Console.WriteLine(TotalSum);
    }
}



