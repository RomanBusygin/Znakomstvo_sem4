Console.WriteLine("Введите элементы массива через кнопку 'Enter': ");
string [] elements = new string [8];

for (int i = 0; i < elements.Length; i++)
{
    elements[i] = Console.ReadLine();
}
PrintArray(elements);

void PrintArray (string [] array)
{
    Console.Write("Вы составили следующий массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}