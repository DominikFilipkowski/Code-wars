using System;

public class Kata
{
    public static int[] Between(int a, int b)
    {
        int length = int.Parse(Console.ReadLine());

        int length = b - a + 1;  
        int[] result = new int[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = a + i;  
        }

        return result;  
    }
}
