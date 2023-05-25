/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

class Program
{
    static void Main()
    {
        int[,] array = new int[4, 4];
        int num = 1;
        int rowStart = 0, rowEnd = 3, colStart = 0, colEnd = 3;

        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            // заполнение верхней строки
            for (int i = colStart; i <= colEnd; i++)
            {
                array[rowStart, i] = num;
                num++;
            }
            rowStart++;

            // заполнение правого столбца
            for (int i = rowStart; i <= rowEnd; i++)
            {
                array[i, colEnd] = num;
                num++;
            }
            colEnd--;

            // заполнение нижней строки
            if (rowStart <= rowEnd)
            {
                for (int i = colEnd; i >= colStart; i--)
                {
                    array[rowEnd, i] = num;
                    num++;
                }
                rowEnd--;
            }

            // заполнение левого столбца
            if (colStart <= colEnd)
            {
                for (int i = rowEnd; i >= rowStart; i--)
                {
                    array[i, colStart] = num;
                    num++;
                }
                colStart++;
            }
        }

        Console.WriteLine("Array:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{array[i, j],3} ");
            }
            Console.WriteLine();
        }
    }
}