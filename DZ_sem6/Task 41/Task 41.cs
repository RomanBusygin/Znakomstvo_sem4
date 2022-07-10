Console.Write("Введите числа через запятую: ");
string str = Console.ReadLine();
string[] numbersStringArray = new string [str.Length];
string numbers = "-0123456789";
int[] numbersArray = new int [numbersStringArray.Length];
int numberSeparator = 0;
int count = 0;

for (int i = 0; i < str.Length; i++)  // Создание строкового массива, в каждой ячейке которого число
{
    for (int j = 0; j < numbers.Length; j++)
    {
        if (str[i] == numbers[j])
        {
        numbersStringArray[numberSeparator] += numbers[j];
        }
        else if (str[i] == ',' || str[i] == ' ')
        {
            numberSeparator++;
            break;
        }
    }
}

for (int i = 0; i < numbersArray.Length; i++)  // Перевод строкового массива в числовой и подсчет положительных чисел
{
    numbersArray[i] = Convert.ToInt32(numbersStringArray[i]);
    if (numbersArray[i] > 0) count++;
}

Console.WriteLine($"Чисел больше 0: {count}");

void PrintIntArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void PrintStringArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
