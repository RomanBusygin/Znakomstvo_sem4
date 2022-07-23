Random rnd = new Random();
int m = rnd.Next(3, 10);
int n = rnd.Next(3, 10);
int[,] array = new int[m, n];
int[] sumRows = new int[m];
int numberMinSum = 1;

FillArrayRandom(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    sumRows[i] = sum;
}

int minSum = sumRows[0];
for (int i = 0; i < sumRows.Length; i++)
{
    if (sumRows[i] < minSum)
    {
        minSum = sumRows[i];
        numberMinSum = i + 1;
    }
}
PrintArray(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numberMinSum}");

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine($" || Сумма строки: {sumRows[i]}");
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
