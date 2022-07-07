Console.Write("Введите число: "); // 452   123456
int number = Convert.ToInt32(Console.ReadLine()),
    sum = 0;

for (int lowDigit = number; lowDigit !=0; lowDigit /=10)
{
    sum += lowDigit % 10;
}
Console.Write($"Сумма разрядов числа {number} равна: {sum}");