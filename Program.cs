Task_55();

void PrintElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0)
        int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];




    void Task_55()
    {
        int[,] array = FillArray();
        FillElement(array);
        Console.WriteLine();
        PrintElements(array);
        Console.WriteLine();
        ArrayFalse(array);
        ArrayChenge(array);
    }

    void ArrayFalse(int[,] array)
    {
        if (array.GetLength(0) != array.GetLength(1))
        {
            Console.WriteLine("Замена не возможна");
            return;
        }

    }

    int[,] ArrayChenge(int[,] array)
    {
        int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                newArray[j, i] = array[i, j];
            }
        }
        PrintElements(newArray);
        return newArray;
    }