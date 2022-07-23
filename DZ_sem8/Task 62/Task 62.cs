Random rnd = new Random();
int size = rnd.Next(4, 20);
int[,] array = new int[size, size];
int number = 1;
int circles = 0;
if (array.GetLength(0) % 2 == 0 ) circles = array.GetLength(0) / 2;
else circles = array.GetLength(0) / 2 + 1;

for (int i = 0; i < circles; i++)
{
    FillCircle(i);
}
PrintArray(array);

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

void FillCircle(int numberCircle)
{
    for (int j = numberCircle; j < array.GetLength(1) - numberCircle; j++)
    {
        array[numberCircle, j] = number++;
    }
    for (int i = numberCircle + 1; i < array.GetLength(0) - numberCircle; i++)
    {
        array[i, array.GetLength(1) - numberCircle - 1] = number++;
    }
    for (int j = array.GetLength(1) - numberCircle - 2; j > numberCircle - 1; j--)
    {
        array[array.GetLength(0) - numberCircle - 1, j] = number++;
    }
    for (int i = array.GetLength(0) - numberCircle - 2; i > numberCircle; i--)
    {
        array[i, numberCircle] = number++;
    }
}
