Console.Write("Введите числа через запятую, например '1,2,-3,4,-5': ");
string user_string = Console.ReadLine();
int size = 1;
for (int i = 0; i < user_string.Length; i++) if (user_string[i] == ',') size++;
string[] numbers_string_array = new string [size];
string examples_numbers = "-0123456789";
int number_separator = 0;
int[] numbers_int_array = new int [size];
int count_pozitive = 0;

for (int i = 0; i < user_string.Length; i++)    //Перевод чисел в строковый массив, в каждой ячейке которого одно число
{
    for (int j = 0; j < examples_numbers.Length; j++)
    {
        if (user_string[i] == examples_numbers[j]) numbers_string_array[number_separator] += examples_numbers[j];
        else if (user_string[i] == ',')
        {
            number_separator++;
            break;
        }
    }
}

for (int i = 0; i < size; i++)   //Перевод чисел из строкового массива в числовой и подсчёт положительных
{
    numbers_int_array[i] = Convert.ToInt32(numbers_string_array[i]);
    if (numbers_int_array[i] > 0) count_pozitive++;
}

Console.Write($"Количество положительных чисел: {count_pozitive}");