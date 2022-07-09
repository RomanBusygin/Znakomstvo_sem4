Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] numbers = new double [size];
int minValueRange = -100;
int maxValueRange = 101;
double minValueArray = numbers[0];
double maxValueArray = numbers[0];

InputArray(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxValueArray) maxValueArray = numbers[i];
    else if (numbers[i] < minValueArray) minValueArray = numbers[i];
}

Console.WriteLine($"Разница между максимальным и минимальным значениями массива равна: {maxValueArray - minValueArray}");

void InputArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValueRange, maxValueRange) + new Random().NextDouble();
    }
}

void PrintArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}