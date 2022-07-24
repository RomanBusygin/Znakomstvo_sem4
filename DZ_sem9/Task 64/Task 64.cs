int numberM = InputInt("Введите число M: ");
int numberN = InputInt("Введите число N: ");

Console.Write($"Натуральные числа от {numberM} до {numberN}: ");
Console.Write(NaturalNumbers(numberM, numberN));

int NaturalNumbers(int m, int n)
{
    if (m < n)
    {
        if (m == n) return n;
        Console.Write(NaturalNumbers(m, n - 1) + ", ");
        return n;
    }
    else if (m > n)
    {
        if (m == n) return n;
        Console.Write(NaturalNumbers(m, n + 1) + ", ");
        return n;
    }
    else return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
