Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;

if (b > 0)
{
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    Console.Write($"Число {a} в степени {b} равно {result}");
}
else if (b == 0) {Console.Write($"Любое число в степени 0 равно 1");}
else Console.Write($"Степень не может быть отрицательной");