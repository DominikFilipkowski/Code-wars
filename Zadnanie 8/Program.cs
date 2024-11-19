using System;

public class MathCheck
{
    
    public static int AreaOrPerimeter(int l, int w)
    {
       
        if (l == w)
        {
            return l * l; 
        }
        else
        {
            return 2 * (l + w); 
        }
    }

    public static void Main()
    {
        
        Console.Write("Podaj L: ");
        int l = int.Parse(Console.ReadLine());

        Console.Write("Podaj W: ");
        int w = int.Parse(Console.ReadLine());


        int result = AreaOrPerimeter(l, w);
        Console.WriteLine($"Wynik: {result}");
    }
}