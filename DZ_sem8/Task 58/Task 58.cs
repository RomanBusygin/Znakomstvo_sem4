Random rnd = new Random();
int m = rnd.Next(2, 10);
int n = rnd.Next(2, 10);
int k = rnd.Next(2, 10);
Console.WriteLine();
int[,] matrixA = new int[m, n];
int[,] matrixB = new int[n, k];
int[,] matrixC = new int[m, k];

FillArrayRandom(matrixA);
FillArrayRandom(matrixB);
matrixC = MatrixMultiplication(matrixA, matrixB);
Console.WriteLine("Матрица А: "); PrintArray(matrixA);
Console.WriteLine("Матрица B: "); PrintArray(matrixB);
Console.WriteLine("Матрица С: "); PrintArray(matrixC);

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

int[,] MatrixMultiplication(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayC.GetLength(1); j++)
        {
            for (int n = 0; n < arrayA.GetLength(1); n++)
            {
                arrayC[i, j] += arrayA[i, n] * arrayB[n, j];
            }
        }
    }
    return arrayC;
}