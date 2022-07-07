Console.WriteLine("Введите элементы массива через кнопку 'Enter': ");
int [] elements = new int [8];

for (int i = 0; i < elements.Length; i++)
{
    elements[i] = Convert.ToInt32(Console.ReadLine());
}
PrintArray(elements);

void PrintArray (int [] array)
{
    Console.Write("Вы составили следующий массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}