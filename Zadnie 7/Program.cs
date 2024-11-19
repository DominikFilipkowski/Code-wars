using System;

public class MathCheck
{
    // Metoda do obliczenia pola (kwadrat) lub obwodu (prostokąt)
    public static int AreaOrPerimeter(int l, int w)
    {
        // Sprawdzamy, czy jest to kwadrat (l == w)
        if (l == w)
        {
            // Jeśli to kwadrat, obliczamy pole: l * l
            return l * l; // Pole kwadratu
        }
        else
        {
            // Jeśli to prostokąt, obliczamy obwód: 2 * (l + w)
            return 2 * (l + w); // Obwód prostokąta
        }
    }

    public static void Main()
    {
        // Odczytanie danych od użytkownika
        Console.Write("Podaj L: ");
        int l = int.Parse(Console.ReadLine()); // Odczytujemy liczbę dla L

        Console.Write("Podaj W: ");
        int w = int.Parse(Console.ReadLine()); // Odczytujemy liczbę dla W

        // Wywołanie metody i wyświetlenie wyniku
        int result = AreaOrPerimeter(l, w);
        Console.WriteLine($"Wynik: {result}");
    }
}