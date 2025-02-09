﻿// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3             4 3 16 3
//  4 3 4 1     =>     4 3 4 1
//  2 9 5 4            4 9 25 4


void Main()
{
    int row = ReadInt("Введите количество строк: ");
    int col = ReadInt("Введите количество столбцов: ");
    int[,] matrix = GenerateMatrix(row, col, 0, 99);
    PrintMatrix(matrix);
    ChangeMatrix(matrix);
    PrintMatrix(matrix);
}

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // Можно указать интервал "i += 2" и тогда доп проверка не нужна
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Здесь тот же интервал "j += 2"
        {
            if (i % 2 == 0 && j % 2 == 0) // Эта проверка!!
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
        Console.WriteLine();
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateMatrix(int rowSize, int colSize, int minValue, int maxValue)
{
    int[,] tempMatrix = new int[rowSize, colSize];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return tempMatrix;
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();