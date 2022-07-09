Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [size];
int minValue = -100;
int maxValue = 101;
int sum = 0;

InputArray(numbers);
PrintArray(numbers);
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0) sum+= numbers[i];
}
Console.Write($"Сумма элементов четных позиций равна {sum}");

void InputArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}