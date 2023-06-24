using System;

class Program
{
    static void Main()
    {
        int wiersze;
        int kolumny;


        Console.WriteLine("wpisz liczbę wierszy");
        wiersze = int.Parse(Console.ReadLine());

        Console.WriteLine("Wpisz liczbę kolumn");
        kolumny = int.Parse(Console.ReadLine());

        Console.WriteLine();







        int[,] array = new int[wiersze, kolumny];

        int num = 1;
        int startRow = 0;
        int endRow = wiersze - 1;
        int startCol = 0;
        int endCol = kolumny - 1;

        while (startRow <= endRow && startCol <= endCol)
        {
            // Wypełnianie górnego wiersza
            for (int col = startCol; col <= endCol; col++)
            {
                array[startRow, col] = num;
                num++;
            }
            startRow++;

            // Wypełnianie prawej kolumny
            for (int row = startRow; row <= endRow; row++)
            {
                array[row, endCol] = num;
                num++;
            }
            endCol--;

            // Wypełnianie dolnego wiersza
            if (startRow <= endRow)
            {
                for (int col = endCol; col >= startCol; col--)
                {
                    array[endRow, col] = num;
                    num++;
                }
                endRow--;
            }

            // Wypełnianie lewej kolumny
            if (startCol <= endCol)
            {
                for (int row = endRow; row >= startRow; row--)
                {
                    array[row, startCol] = num;
                    num++;
                }
                startCol++;
            }
        }

        // Wypisywanie tablicy na ekranie
        for (int row = 0; row < wiersze; row++)
        {
            for (int col = 0; col < kolumny; col++)
            {
                Console.Write(array[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
