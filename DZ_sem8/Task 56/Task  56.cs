Random rnd = new Random();
int size = InputInt("Введите размерность квадратного массива: ");
int[,] array = new int[size, size];
int[] sumRowsArray = new int[size];
int numberMinSum = 1;

FillArrayRandom(array);
PrintArray(array);
sumRowsArray = SumRowsToArray(array);
for (int i = 0; i < sumRowsArray.Length; i++)
{
    int minSum = sumRowsArray[0];
    if (sumRowsArray[i] < minSum)
    {
        numberMinSum = i + 1;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numberMinSum}");

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

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
}

int[] SumRowsToArray(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumRows[i] = sum;
    }
    return sumRows;
}

int InputInt (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
