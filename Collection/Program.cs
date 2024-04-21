using System;

class Program
{
    static int[,] labirynth1 = new int[,]
    {
        {1, 1, 1, 1, 1, 1, 1 },
        {1, 0, 0, 0, 0, 0, 1 },
        {1, 0, 1, 1, 1, 0, 1 },
        {0, 0, 0, 0, 1, 0, 0 },
        {1, 1, 0, 0, 1, 1, 1 },
        {1, 1, 1, 0, 1, 1, 1 },
        {1, 1, 1, 0, 1, 1, 1 }
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Количество выходов в лабиринте: " + CountExits());
    }

    static int CountExits()
    {
        int count = 0;
        for (int i = 0; i < labirynth1.GetLength(0); i++)
        {
            for (int j = 0; j < labirynth1.GetLength(1); j++)
            {
                if (labirynth1[i, j] == 0 && (i == 0 || i == labirynth1.GetLength(0) - 1 || j == 0 || j == labirynth1.GetLength(1) - 1))
                {
                    count++;
                }
            }
        }
        return count;
    }
}