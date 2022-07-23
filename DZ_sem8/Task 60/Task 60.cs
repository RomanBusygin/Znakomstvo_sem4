Random rnd = new Random();
int m = rnd.Next(2, 5);
int n = rnd.Next(2, 5);
int z = rnd.Next(2, 5);
int[,,] array = new int[m, n, z];
int number = 10;

FillArray(array);
PrintArray(array);

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = number++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i}, {j}, {k}) | ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
