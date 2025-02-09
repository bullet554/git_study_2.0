﻿// Мой подход!!
void Main()
{
    int[,] matrix = new int[3, 5];
    CreateArray(matrix);
    PrintArray(matrix);
}

void CreateArray(int[,] matrix)
{

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(1, 11);
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}

Main();



// Подход препода из лекций!!
// int[,] CreateMatrix(int rowCount, int columnCount)
// {
//     int[,] matrix = new int[rowCount, columnCount];

//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = rnd.Next(1, 11);
//     }
//     return matrix;
// }

// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// int[,] matrix = CreateMatrix(4, 5);
// ShowMatrix(matrix);