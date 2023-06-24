using System;

class Program
{
    static void Main()
    {
        int wiersze,kolumny;


        Console.WriteLine("Podaj liczbę wierszy");
        wiersze = int.Parse(Console.ReadLine()); //liczba wierszy

        Console.WriteLine("podaj liczbę kolumn");
        kolumny = int.Parse(Console.ReadLine()); //Liczba kolumn

        Console.WriteLine();


        int[,] tablica = new int[wiersze, kolumny];

        for (int i = 0; i < wiersze; i++)
        {
            if (i % 2 == 0)
            {
                // Wiersze parzyste - wypełnianie rosnąco
                for (int j = 0; j < kolumny; j++)
                {
                    tablica[i, j] = i * kolumny + j + 1;
                }
            }
            else
            {
                // Wiersze nieparzyste - wypełnianie malejąco
                for (int j = kolumny - 1; j >= 0; j--)
                {
                    tablica[i, j] = i * kolumny + (kolumny - j);
                }
            }
        }

        // Wyświetlanie tablicy
        for (int i = 0; i < wiersze; i++)
        {
            for (int j = 0; j < kolumny; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
