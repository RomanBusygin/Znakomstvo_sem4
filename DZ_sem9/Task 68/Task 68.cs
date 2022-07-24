int numberM = InputInt("Введите число M: ");
int numberN = InputInt("Введите число N: ");

Console.WriteLine($"Значение функции Аккермана для чисел {numberM} и {numberN} равно: {AckermanFunction(numberM, numberN)}");

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    return -1; // Если какое либо число отрицательное
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
