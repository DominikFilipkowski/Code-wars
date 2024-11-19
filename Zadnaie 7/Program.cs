using System;

public class Kata
{
    public static string DrawStairs(int n)
    {
        Console.WriteLine("Podaj n:");
        int liczba = int.Parse(Console.ReadLine());

        string result = "";

        for (int i = 1; i <= liczba; i++)
        {

            result += new string(' ', i - 1) + "I" + "\n";
        }

        return result;
    }

    public static void Main()
    {

        string stairs = DrawStairs(int.Parse(Console.ReadLine()));
        Console.WriteLine(stairs);
    }
}
