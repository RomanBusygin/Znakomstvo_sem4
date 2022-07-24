int numberM = InputInt("Введите число M: ");
int numberN = InputInt("Введите число N: ");

Console.Write($"Сумма натуральных чисел от {numberM} до {numberN} равна: {SumElements(numberM, numberN)}");

int SumElements(int m, int n)
{
    if (m < n)
    {
        if (m == n) return n;
        return m + SumElements(m + 1, n);
    }
    if (m > n)
    {
        if (m == n) return n;
        return m + SumElements(m - 1, n);
    }
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
