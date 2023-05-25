﻿/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] array = { { 5, 7, 1 }, { 3, 2, 4 }, { 9, 8, 6 } };

// Проходим по каждой строке массива
for (int i = 0; i < array.GetLength(0); i++)
{
    // Проходим по каждому элементу в строке
    for (int j = 0; j < array.GetLength(1); j++)
    {
        // Проходим по каждому элементу в строке, начиная с элемента j+1
        for (int k = j + 1; k < array.GetLength(1); k++)
        {
            // Если текущий элемент меньше следующего, меняем их местами
            if (array[i, j] < array[i, k])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}

// Выводим отсортированный массив на экран
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
