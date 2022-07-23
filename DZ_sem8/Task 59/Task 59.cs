Random rnd = new Random();
int row = rnd.Next(3, 7);
int column = rnd.Next(3, 7);
int[,] array = new int[row, column];
int[,] arrayWithoutColumn = new int[array.GetLength(0), array.GetLength(1) - 1];
int[,] arrayWithoutRow = new int[arrayWithoutColumn.GetLength(0) - 1, arrayWithoutColumn.GetLength(1)];
int min = 0;
int indexI = 0;
int indexJ = 0;

FillArray(array);
PrintArray(array);
min = MinElementArray(array);
Console.WriteLine($"Минимальный элемент: {min} ({indexI}, {indexJ})");
arrayWithoutColumn = DeleteColumn(array);
arrayWithoutRow = DeleteRow(arrayWithoutColumn);
PrintArray(arrayWithoutRow);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10, 100);
        }
    }
}

int MinElementArray(int[,] array)
{
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                indexI = i;
                indexJ = j;
            }
        }
    }
    return min;
}

int[,] DeleteColumn(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < indexJ; j++)
        {
            newArray[i, j] = array[i, j];
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = indexJ + 1; j < array.GetLength(1); j++)
        {
            newArray[i, j - 1] = array[i, j];
        }
    }
    return newArray;
}

int[,] DeleteRow(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1)];
    for (int i = 0; i < indexI; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i, j] = array[i, j];
        }
    }
    for (int i = indexI + 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i - 1, j] = array[i, j];
        }
    }
    return newArray;
}