﻿// Задание 2: Поиск суммы элементов в каждом столбце.

// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// находит сумму элементов в каждом столбце массива и выводит её.

// Пример входных данных:
// 1 2 3
// 4 5 6
// 7 8 9
// 10 11 12

// Пример результата:
// Сумма элементов в столбце 0: 22
// Сумма элементов в столбце 1: 26
// Сумма элементов в столбце 2: 30

// Подсказка: Используйте вложенные циклы для прохода по столбцам и строкам
// массива. Суммируйте значения в каждом столбце.


void Main()
{
    int[,] array =
    {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
    { 10, 11, 12 }
    };

    FindSumInColumns(array);
}

void FindSumInColumns(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[] columnSums = new int[cols];

    for (int j = 0; j < cols; j++)
    {           
        for (int i = 0; i < rows; i++)
        {
            columnSums[j] += array[i, j];
        }
    }
    
    Console.WriteLine("Суммы столбцов:");
        for (int j = 0; j < cols; j++)
        {
            Console.WriteLine($"Столбец {j + 1}: {columnSums[j]}");
        }
}

Main();