int n = InputInt("Введите количество строк треугольника Паскаля: ");
Console.WriteLine();
int[,] arrayPascal = new int[n, n];
string[,] strPasc = new string[n, n];
string[] space = new string[n - 1];
space[space.Length - 1] = "    ";
for (int i = space.Length - 2; i > - 1; i--)
{
    space[i] = space[i + 1] + "     ";
}

CalculatePascal();
for (int i = 0; i < n; i++) // перевод числового массива в строковый и избавление от нолей
{
    for (int j = 0; j < n; j++)
    {
        if (arrayPascal[i, j] != 0) strPasc[i, j] = Convert.ToString(arrayPascal[i, j]) + "    ";
        else strPasc[i, j] = string.Empty;
    }
}
ShiftArray(strPasc);
PrintPascal(strPasc);

int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintPascal(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "     ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void CalculatePascal()
{
    for (int i = 0; i < n; i++)
    {
        arrayPascal[i, 0] = 1;
        arrayPascal[i, i] = 1;
        for (int j = 1; j < i; j++)
        {
            arrayPascal[i, j] = arrayPascal[i - 1, j - 1] + arrayPascal[i - 1, j];

        }
    }
}

void ShiftArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        strPasc[i, 0] = space[i] + strPasc[i, 0];
    }
}
