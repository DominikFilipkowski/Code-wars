using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if (input == null || input.Length == 0)
            return new int[0];


        int countPositives = input.Count(x => x > 0);
        int sumNegatives = input.Where(x => x < 0).Sum();
        return new int[] { countPositives,sumNegatives};
    }
}

public class Program
    {
    public static void Main()
    {
        int[] input = { 1, 2, 3, 4, 5, -7, -8, -9 };
        int[] result = Kata.CountPositivesSumNegatives(input);
        if (result.Length > 0)
        {
            Console.WriteLine($"[{ result[0]},{ result[1]}]");

        }
    }


}